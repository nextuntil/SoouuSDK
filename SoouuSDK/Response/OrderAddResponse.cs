using System;

namespace SoouuSDK.Response {
    /// <summary>
    /// 直充订单返回结果
    /// </summary>
    public class OrderAddResponse : SoouuResponse {

        /// <summary>
        /// 请求结果
        /// </summary>
        public bool Success
        {
            get
            {
                return MessageCode == null;
            }
        }

        /// <summary>
        /// 异常Code（成功时不返回）
        /// </summary>
        public string MessageCode { set; get; }

        /// <summary>
        /// 异常消息
        /// </summary>
        public string MessageInfo { set; get; }

        /// <summary>
        /// 树鱼订单号
        /// </summary>
        public string OrderId { set; get; }

        /// <summary>
        /// 树鱼商品编号
        /// </summary>
        public long ProductId { set; get; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public long BuyNum { set; get; }

        /// <summary>
        /// 充值帐号
        /// </summary>
        public string Account { set; get; }

        /// <summary>
        /// 充值区(中文)
        /// </summary>
        public string Area { set; get; }

        /// <summary>
        /// 充值服(中文)
        /// </summary>
        public string Server { set; get; }

        /// <summary>
        /// 计费方式(中文)
        /// </summary>
        public string Type { set; get; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// 订单状态(未处理,处理中,成功,失败,可疑)
        /// </summary>
        public string Status { set; get; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public DateTime FinishTime { set; get; }

        /// <summary>
        /// 充值描述
        /// </summary>
        public string StatusMsg { set; get; }

        /// <summary>
        /// 进价
        /// </summary>
        public decimal PurchasePrice { set; get; }

    }
}
