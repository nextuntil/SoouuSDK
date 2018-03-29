using SoouuSDK.Response;

namespace SoouuSDK.Request {
    public class OrderAddRequest : ISoouuRequest<OrderAddResponse> {
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
        /// 充值帐号
        /// </summary>
        public string chargeaccount { set; get; }

        /// <summary>
        /// 充值密码（特殊游戏）
        /// </summary>
        public string chargepassword { set; get; }

        /// <summary>
        /// 充值游戏（中文）
        /// </summary>
        public string chargegame { set; get; }

        /// <summary>
        /// 充值区（中文）
        /// </summary>
        public string chargeregion { set; get; }

        /// <summary>
        /// 充值服（中文）
        /// </summary>
        public string chargeserver { set; get; }

        /// <summary>
        /// 计费方式（中文）
        /// </summary>
        public string chargetype { set; get; }

        /// <summary>
        /// 回调地址
        /// </summary>
        public string notifyurl { set; get; }

        /// <summary>
        /// 买家真实IP（区域商品必须传）
        /// </summary>
        public string buyerip { set; get; }

        /// <summary>
        /// 游戏角色
        /// </summary>
        public string rolename { set; get; }

        /// <summary>
        /// 剩余数量
        /// </summary>
        public string remainingnumber { set; get; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string contacttype { set; get; }

        /// <summary>
        /// 联系QQ
        /// </summary>
        public string contactqq { set; get; }

        /// <summary>
        /// 请求方法
        /// </summary>
        public string method
        {
            get
            {
                return "kamenwang.order.add";
            }
        }
    }
}
