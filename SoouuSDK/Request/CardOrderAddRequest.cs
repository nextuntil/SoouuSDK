using SoouuSDK.Response;
namespace SoouuSDK.Request {
    /// <summary>
    /// 卡密提卡
    /// </summary>
   public class CardOrderAddRequest:ISoouuRequest<CardOrderAddResponse> {

        /// <summary>
        /// 合作商家订单号
        /// </summary>
        public string customerorderno { set; get; }

        /// <summary>
        /// 树鱼商品编号
        /// </summary>
        public long productid { set; get; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public long buynum { set; get; }

        /// <summary>
        /// 请求方法
        /// </summary>
        public string method
        {
            get
            {
                return "kamenwang.order.cardorder.add";
            }
        }

    }
}
