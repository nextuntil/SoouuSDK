using SoouuSDK.Response;
namespace SoouuSDK.Request {
    /// <summary>
    /// 获取商品
    /// </summary>
   public class GoodsGetRequest:ISoouuRequest<GoodsGetResponse> {

        /// <summary>
        /// 商品分类ID
        /// </summary>
        public long goodscatalogid { set; get; }

        /// <summary>
        /// 请求方法
        /// </summary>
        public string method
        {
            get
            {
                return "kamenwang.goods.get";
            }
        }

    }
}
