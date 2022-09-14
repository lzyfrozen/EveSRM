using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Newtonsoft.Json;

namespace EveSRM
{
    public partial class SRMDockForm : Form
    {
        private readonly IEdiRequest _ediRequest = new EdiRequest();
        public SRMDockForm()
        {
            InitializeComponent();
        }
        private List<BatPackModuleInfo> listBatPackModuleInfo = new List<BatPackModuleInfo>();

        private void SRMDockForm_Load(object sender, EventArgs e)
        {
            InitSrmDock();
            txtOrdNo.Text = "202205170001";
            txtSerialNum.Text = "EP30YA00001";
            txtBatteryPackGbtCode.Text = "04QPE120YH411JC410000001";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var strCondition = string.Empty;
            if (string.IsNullOrWhiteSpace(txtOrdNo.Text) || string.IsNullOrWhiteSpace(txtSerialNum.Text) || string.IsNullOrWhiteSpace(txtBatteryPackGbtCode.Text))
            {
                MessageBox.Show("订单号、序列号、电池包GBT编码不能为空");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtOrdNo.Text))
            {
                strCondition += $@" and transNo = :transNo";
            }
            if (!string.IsNullOrWhiteSpace(txtSerialNum.Text))
            {
                strCondition += $@" and serialNum = :serialNum";
            }
            if (!string.IsNullOrWhiteSpace(txtBatteryPackGbtCode.Text))
            {
                strCondition += $@" and batteryPackGbtCode = :batteryPackGbtCode";
            }
            var srmCode = cmbSRM.SelectedValue.ToString();
            var sql = $@"select * from WMSHZ_CUS_BATTERY_PACK_MODULE_INFO
                        where organizationid =:organizationid  and warehouseid = :warehouseid and srmcode = :srmcode {strCondition}";
            listBatPackModuleInfo = DbHelper.conn.Query<BatPackModuleInfo>(sql, new
            {
                organizationid = AppSettings.OrganizationId,
                warehouseid = AppSettings.WarehouseId,
                srmcode = srmCode,
                transNo = txtOrdNo.Text,
                serialNum = txtSerialNum.Text,
                batteryPackGbtCode = txtBatteryPackGbtCode.Text,
            }).ToList();

            lbNum.Text = lbNum.Text.Substring(0, lbNum.Text.IndexOf("：") + 1) + listBatPackModuleInfo.Count.ToString();

            if (listBatPackModuleInfo.Count() == 0)
            {
                MessageBox.Show("该订单号或序列号或者电池包GBT编码数据不存在");
                return;
            }
            var message = MapToSendMessage(listBatPackModuleInfo);

            txtMessage.Text = message.ToJsonDate(true);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (listBatPackModuleInfo.Count() == 0)
            {
                MessageBox.Show("该单号或者序列号或者电池包GBT编码数据不存在");
                return;
            }
            var message = MapToSendMessage(listBatPackModuleInfo);
            SendSRM(message, listBatPackModuleInfo.FirstOrDefault().transNo);
        }

        private void SendSRM(HozonMessage message, string ordNo)
        {

            FeedbackDto dto = new FeedbackDto();
            dto.PlatformNo = "HOZON";
            dto.Method = AppSettings.app(new string[] { "HOZON", "ApiUrl" });
            dto.FeedbackType = FeedbackTypes.合众SRM;
            dto.Header = GetHeader();
            dto.Data = message.ToJsonDate();

            try
            {
                var result = _ediRequest.Feedback<HozonResult>(dto);
                txtFeedback.Text = result.ToJsonDate(true);

                if (result.executeResult.Equals("SUCCESS"))
                {
                    ModifyData(ordNo);
                }
            }
            catch (Exception ex)
            {
                txtFeedback.Text = $"发送失败,{Environment.NewLine}{ex.ToString()}";
                MessageBox.Show($"发送失败,{ex.ToString()}");
            }
        }

        private Dictionary<string, string> GetHeader()
        {
            var dicHeader = new Dictionary<string, string>();
            var access_token = GetToken();
            dicHeader.Add("Authorization", $"Bearer {access_token}");

            return dicHeader;
        }

        private string GetToken()
        {
            var token = string.Empty;
            var data = new HozonTokenRequest();
            data.grant_type = AppSettings.app(new string[] { "HOZON", "Auth", "grant_type" });
            data.client_id = AppSettings.app(new string[] { "HOZON", "Auth", "client_id" });
            data.client_secret = AppSettings.app(new string[] { "HOZON", "Auth", "client_secret" });
            data.scope = AppSettings.app(new string[] { "HOZON", "Auth", "scope" });
            var dicParams = new Dictionary<string, string>();
            dicParams.Add("grant_type", data.grant_type);
            dicParams.Add("client_id", data.client_id);
            dicParams.Add("client_secret", data.client_secret);
            dicParams.Add("scope", data.scope);

            FeedbackDto dto = new FeedbackDto();
            dto.PlatformNo = "HOZON";
            dto.Method = AppSettings.app(new string[] { "HOZON", "Auth", "TokenApiUrl" });
            dto.FeedbackType = FeedbackTypes.合众SRM;
            //dto.Data = data.ToJsonDate();
            dto.Params = dicParams;
            try
            {
                var result = _ediRequest.Oauth<HozonTokenResult>(dto);
                token = result.access_token;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show($"token获取失败,{ex.ToString()}");
            }
            return token;
        }

        private HozonMessage MapToSendMessage(List<BatPackModuleInfo> listBatPackModuleInfo)
        {
            var supplierNum = AppSettings.app(new[] { "HOZON", "SupplierNum" });
            var factory = AppSettings.app(new[] { "HOZON", "Factory" });
            var seqNo = "0001";
            long index = 0;
            var message = new HozonMessage();
            var body = new HozonBodyMessage();

            body.orderNum = $"{supplierNum}{DateTime.Now:yyyyMMdd}{seqNo}V";
            body.productPartNum = listBatPackModuleInfo.FirstOrDefault().productPartNum;
            body.invOrganizationCode = factory;
            body.supplierNum = supplierNum;

            foreach (var item in listBatPackModuleInfo)
            {
                var det = new HozonBatteryOrderLine();
                det.serialNum = item.serialNum;
                det.powerBatteryOrderNum = item.powerBatteryOrderNum;
                det.powerBatteryRetrospectCode = item.powerBatteryRetrospectCode;
                det.bmu1RetrospectCode = item.bmu1RetrospectCode;
                det.bmu2RetrospectCode = item.bmu2RetrospectCode;
                det.bduRetrospectCode = item.bduRetrospectCode;
                det.bcuRetrospectCode = item.bcuRetrospectCode;
                det.batteryPackGbtCode = item.moduleGbtCode;
                det.moduleType = item.moduleType;
                det.moduleGbtCode = item.moduleGbtCode;
                det.moduleRetrospectCode = item.moduleRetrospectCode;
                det.batteryCoreType = item.batteryCoreType;
                det.batteryCoreGbtCode = item.batteryCoreGbtCode;
                det.creationDate = item.creationDate;
                det.remarkOne = item.remarkOne;
                det.remarkTwo = item.remarkTwo;
                body.hozonBatteryOrderLines.Add(det);
            }
            body.hozonBatteryOrderLines.ForEach(x => { x.lineNum = ++index; });

            message.body.Add(body);
            return message;
        }

        private void ModifyData(string OrdNo)
        {
            var strCondition = string.Empty;
            if (string.IsNullOrWhiteSpace(OrdNo))
            {
                MessageBox.Show("订单号不能为空");
                return;
            }
            if (!string.IsNullOrWhiteSpace(OrdNo))
            {
                strCondition += $@" and transNo = :transNo";
            }
            var srmCode = cmbSRM.SelectedValue.ToString();
            var sql = $@"update WMSHZ_CUS_BATTERY_PACK_MODULE_INFO set ediSendFlag='Y',ediSendTime=sysdate
                        where organizationid =:organizationid  and warehouseid = :warehouseid and srmcode = :srmcode {strCondition}";
            var res = DbHelper.conn.Execute(sql, new
            {
                organizationid = AppSettings.OrganizationId,
                warehouseid = AppSettings.WarehouseId,
                srmcode = srmCode,
                transNo = txtOrdNo.Text
            });
            if (res >= 0)
            {
                MessageBox.Show($"单号：{OrdNo},回传成功!");
            }
            else
            {
                MessageBox.Show($"单号：{OrdNo},回传成功!");
            }
        }

        private void InitSrmDock()
        {
            Dictionary<string, string> dicBillType = new Dictionary<string, string>();
            dicBillType.Add("HOZON", "合众SRM");
            BindingSource bsBillType = new BindingSource();
            bsBillType.DataSource = dicBillType;
            cmbSRM.DataSource = bsBillType;
            cmbSRM.ValueMember = "Key";
            cmbSRM.DisplayMember = "Value";
        }
    }
}
