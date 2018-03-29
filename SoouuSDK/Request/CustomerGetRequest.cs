using SoouuSDK.Response;

namespace SoouuSDK.Request {
    /// <summary>
    /// 获取用户信息
    /// </summary>
    public class CustomerGetRequest : ISoouuRequest<CustomerGetResponse> {

        /// <summary>
        /// 请求方法
        /// </summary>
        public string method
        {
            get
            {
                return "kamenwang.customer.get";
            }
        }
    }
}
