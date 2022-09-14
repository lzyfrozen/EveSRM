using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveSRM
{
    public class HozonMessage
    {
        public HozonHeaderMessage header { get; set; } = new HozonHeaderMessage();

        public List<HozonBodyMessage> body { get; set; } = new List<HozonBodyMessage>();
    }

    public class HozonHeaderMessage
    {
        /// <summary>
        /// 应用组
        /// </summary>
        public string applicationCode { get; set; } = "GOINGLINK_CLOUD_DEV";

        /// <summary>
        /// 应用
        /// </summary>
        public string applicationGroupCode { get; set; } = "PUBLIC_CLOUD";

        /// <summary>
        /// 批次号
        /// </summary>
        public string batchNum { get; set; } = DateTime.Now.ToString("yyyyMMddHmmss");

        /// <summary>
        /// 外部系统
        /// </summary>
        public string externalSystemCode { get; set; } = "HOZON_LXM3U9DS1J";

        /// <summary>
        /// 接口编码
        /// </summary>
        public string interfaceCode { get; set; } = "SITF_SCUX_BATTERY_ORDER_IMP";
    }

    public class HozonBodyMessage
    {
        /// <summary>
        /// 订单号 编码规则【供应商ERP编码+年月日+四位流水+V】（示例：1AB201905270001V）		
        /// </summary>
        public string orderNum { get; set; }

        /// <summary>
        /// 零件产品号
        /// </summary>
        public string productPartNum { get; set; }

        /// <summary>
        /// 工厂
        /// </summary>
        public string invOrganizationCode { get; set; }

        /// <summary>
        /// erp供应商编码
        /// </summary>
        public string supplierNum { get; set; }

        /// <summary>
        /// 数据来源    固定值：INTERFACE
        /// </summary>
        public string dataSource { get; set; } = "INTERFACE";

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime creationDate { get; set; } = DateTime.Now;

        /// <summary>
        /// 订单状态    固定值：NEW
        /// </summary>
        public string statusCode { get; set; } = "NEW";

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 预留字段1
        /// </summary>
        public string attributeVarchar1 { get; set; }

        /// <summary>
        /// 预留字段2
        /// </summary>
        public string attributeVarchar2 { get; set; }

        /// <summary>
        /// 预留字段3
        /// </summary>
        public string attributeVarchar3 { get; set; }

        /// <summary>
        /// 预留字段4
        /// </summary>
        public string attributeVarchar4 { get; set; }

        /// <summary>
        /// 预留字段5
        /// </summary>
        public string attributeVarchar5 { get; set; }

        public List<HozonBatteryOrderLine> hozonBatteryOrderLines { get; set; } = new List<HozonBatteryOrderLine>();
    }

    public class HozonBatteryOrderLine
    {

        /// <summary>
        /// 订单行号
        /// </summary>
        public long lineNum { get; set; }

        /// <summary>
        /// 订单行状态   固定值 NEW
        /// </summary>
        public string lineStatus { get; set; } = "NEW";

        /// <summary>
        /// 序列号
        /// </summary>
        public string serialNum { get; set; }

        /// <summary>
        /// 动力电池总成订单号
        /// </summary>
        public string powerBatteryOrderNum { get; set; }

        /// <summary>
        /// 动力电池总成精确追溯码
        /// </summary>
        public string powerBatteryRetrospectCode { get; set; }

        /// <summary>
        /// BMU1精确追溯码
        /// </summary>
        public string bmu1RetrospectCode { get; set; }

        /// <summary>
        /// BMU2精确追溯码
        /// </summary>
        public string bmu2RetrospectCode { get; set; }

        /// <summary>
        /// BDU精确追溯码
        /// </summary>
        public string bduRetrospectCode { get; set; }

        /// <summary>
        /// BCU精确追溯码
        /// </summary>
        public string bcuRetrospectCode { get; set; }

        /// <summary>
        /// 电池包GBT编码
        /// </summary>
        public string batteryPackGbtCode { get; set; }

        /// <summary>
        /// 模组型号
        /// </summary>
        public string moduleType { get; set; }

        /// <summary>
        /// 模组GBT编码
        /// </summary>
        public string moduleGbtCode { get; set; }

        /// <summary>
        /// 模组精确追溯码
        /// </summary>
        public string moduleRetrospectCode { get; set; }

        /// <summary>
        /// 电芯型号
        /// </summary>
        public string batteryCoreType { get; set; }

        /// <summary>
        /// 电芯单体GBT编码
        /// </summary>
        public string batteryCoreGbtCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime creationDate { get; set; }

        /// <summary>
        /// 备注1
        /// </summary>
        public string remarkOne { get; set; }

        /// <summary>
        /// 备注2
        /// </summary>
        public string remarkTwo { get; set; }
    }

    public class HozonTokenRequest
    {
        /// <summary>
        /// 授权模式
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        /// 客户端Id
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        /// 客户端密钥
        /// </summary>
        public string client_secret { get; set; }

        /// <summary>
        /// 作用域
        /// </summary>
        public string scope { get; set; }
    }

    public class HozonTokenResult
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public long expires_in { get; set; }
        public string scope { get; set; }
    }
}
