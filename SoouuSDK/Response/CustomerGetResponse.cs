namespace SoouuSDK.Response {
    public class CustomerGetResponse :SoouuResponse{
        /// <summary>
        /// 树鱼云接口昵称
        /// </summary>
        public string NickName { set; get; }

        /// <summary>
        /// 树鱼云接口余额
        /// </summary>
        public decimal Balance { set; get; }

        /// <summary>
        /// 0表示账户已被禁用，1表示账户状态正常
        /// </summary>
        public string IsOpen { set; get; }
    }
}