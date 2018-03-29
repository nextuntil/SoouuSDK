namespace SoouuSDK.Response {
    /// <summary>
    /// 商品类目（列表项）
    /// </summary>
    public class CatalogsGetResponse : SoouuResponse {
        /// <summary>
        /// 分类ID
        /// </summary>
        public long GoodsCatalogID { set; get; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string GoodsCatalogName { set; get; }
    }
}
