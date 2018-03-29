using SoouuSDK.Response;

namespace SoouuSDK.Request {
    /// <summary>
    /// 商品类目
    /// </summary>
    public class CatalogsGetRequest:ISoouuRequest<CatalogsGetResponse> {
        /// <summary>
        /// 请求方法
        /// </summary>
        public string method
        {
            get
            {
                return "kamenwang.catalogs.get";
            }
        }
    }
}
