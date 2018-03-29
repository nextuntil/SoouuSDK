using SoouuSDK.Response;

namespace SoouuSDK.Request {
    /// <summary>
    /// 话费直充
    /// </summary>
    public class PhoneOrderAddRequest : ISoouuRequest<OrderAddResponse> {
        /// <summary>
        /// 充值手机号
        /// </summary>
        public string chargephone { set; get; }

        /// <summary>
        /// 充值面值
        /// </summary>
        public string chargeparvalue { set; get; }

        /// <summary>
        /// 合作商家订单号
        /// </summary>
        public string customerorderno { set; get; }

        /// <summary>
        /// 回调地址
        /// </summary>
        public string notifyurl { set; get; }

        /// <summary>
        /// 请求方法
        /// </summary>
        public string method
        {
            get
            {
                return "kamenwang.phoneorder.add";
            }
        }
    }
}
