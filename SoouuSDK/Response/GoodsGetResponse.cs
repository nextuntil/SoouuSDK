namespace SoouuSDK.Response {
    /// <summary>
    /// 获取商品（列表项）
    /// </summary>
    public class GoodsGetResponse : SoouuResponse {
        /// <summary>
        /// 商品ID
        /// </summary>
        public long GoodsID { set; get; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { set; get; }

        /// <summary>
        /// 商品类型(在线直储，卡密直储，卡密，手工代充)
        /// </summary>
        public string GoodsType { set; get; }

        /// <summary>
        /// 商品面值
        /// </summary>
        public decimal GoodsParvalue { get; set; }

        /// <summary>
        /// 销售价
        /// </summary>
        public decimal SellPrice { get; set; }

        /// <summary>
        /// 进价
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// 禁售时间（保留字段）
        /// </summary>
        public System.DateTime BanBuyTime { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        public string TemplateGuid { get; set; }

        /// <summary>
        /// 库存状态（保留字段）可以也可以不给数据展示的，用户不用太关注这个字段，直充和取卡不用关注
        /// </summary>
        public int StockType { get; set; }

        /// <summary>
        /// 是否销售（保留字段）
        /// </summary>
        public string IsSell { get; set; }

        /// <summary>
        /// 购买数量限制（保留字段）
        /// </summary>
        public string SelectNum { get; set; }
    }
}
