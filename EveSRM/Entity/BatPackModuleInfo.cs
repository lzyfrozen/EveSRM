using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveSRM
{
    public class BatPackModuleInfo
    {
        /// <summary>
        /// 组织编号
        /// </summary>
        public string organizationId { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string warehouseId { get; set; }

        /// <summary>
        /// 货主
        /// </summary>
        public string customerId { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        public string transNo { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public string employee { get; set; }

        /// <summary>
        /// 对接日期
        /// </summary>
        public DateTime opTime { get; set; }

        /// <summary>
        /// 零件产品号
        /// </summary>
        public string productPartNum { get; set; }

        /// <summary>
        /// 法规号
        /// </summary>
        public string statuteNum { get; set; }

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

        /// <summary>
        /// 客户SRM系统代码
        /// </summary>
        public string srmCode { get; set; }

        /// <summary>
        /// 新增时间
        /// </summary>
        public string addTime { get; set; }

        /// <summary>
        /// 新增人员
        /// </summary>
        public string addWho { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public string editTime { get; set; }

        /// <summary>
        /// 编辑人员
        /// </summary>
        public string editWho { get; set; }

        /// <summary>
        /// 自定义01
        /// </summary>
        public string udf01 { get; set; }

        /// <summary>
        /// 自定义02
        /// </summary>
        public string udf02 { get; set; }

        /// <summary>
        /// 自定义03
        /// </summary>
        public string udf03 { get; set; }

        /// <summary>
        /// 自定义04
        /// </summary>
        public string udf04 { get; set; }

        /// <summary>
        /// 自定义05
        /// </summary>
        public string udf05 { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string noteText { get; set; }

        /// <summary>
        /// 当前版本号
        /// </summary>
        public string currentVersion { get; set; }

        /// <summary>
        /// 操作流水标记
        /// </summary>
        public string oprSeqFlag { get; set; }

        /// <summary>
        /// EDI发送标记
        /// </summary>
        public string ediSendFlag { get; set; }

        /// <summary>
        /// EDI发送时间
        /// </summary>
        public string ediSendTime { get; set; }

        /// <summary>
        /// 接口错误代码
        /// </summary>
        public string ediErrorCode { get; set; }

        /// <summary>
        /// <summary>
        /// 接口错误消息
        /// </summary>
        public string ediErrorMessage { get; set; }
    }
}
