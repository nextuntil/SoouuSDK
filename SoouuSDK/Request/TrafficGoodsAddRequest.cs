using SoouuSDK.Response;

namespace SoouuSDK.Request {
    /// <summary>
    /// 流量直充
    /// </summary>
    public class TrafficGoodsAddRequest : ISoouuRequest<OrderAddResponse> {

        /// <summary>
        /// 合作商家订单号
        /// </summary>
        public string customerorderno { set; get; }

        /// <summary>
        /// 充值手机号码
        /// </summary>
        public string chargephone { set; get; }

        /// <summary>
        /// 流量大小(注：单位为MB，1GB=1024MB)
        /// </summary>
        public string chargeparvalue { set; get; }

        /// <summary>
        /// 流量类型(注：1.全国  0.省内)
        /// </summary>
        public string areatype { set; get; }

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
                return "kamenwang.trafficgoods.add";
            }
        }
    }
}
