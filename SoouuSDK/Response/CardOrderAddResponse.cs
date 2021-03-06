﻿using System;
using System.Collections.Generic;

namespace SoouuSDK.Response {
    /// <summary>
    /// 卡密提卡
    /// </summary>
    public class CardOrderAddResponse : SoouuResponse {

        /// <summary>
        /// 请求结果
        /// </summary>
        public bool Success
        {
            get
            {
                return MessageCode == null;
            }
        }

        /// <summary>
        /// 异常Code（成功时不返回）
        /// </summary>
        public string MessageCode { set; get; }

        /// <summary>
        /// 异常消息
        /// </summary>
        public string MessageInfo { set; get; }

        /// <summary>
        /// 树鱼订单号
        /// </summary>
        public string OrderId { set; get; }

        /// <summary>
        /// 树鱼商品编号
        /// </summary>
        public long ProductId { set; get; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public long BuyNum { set; get; }

        /// <summary>
        /// 订单状态(未处理,处理中,成功,失败,可疑)
        /// </summary>
        public string Status { set; get; }

        /// <summary>
        /// 订单创建消息
        /// </summary>
        public string StatusMsg { set; get; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public DateTime FinishTime { set; get; }

        /// <summary>
        /// 卡密列表（加密过的）
        /// </summary>
        public List<CardInfo> Cards { set; get; }

        /// <summary>
        /// 进价
        /// </summary>
        public decimal PurchasePrice { set; get; }
    }

    /// <summary>
    /// 卡密信息实体
    /// </summary>
    public class CardInfo {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNumber { set; get; }

        /// <summary>
        /// 卡密
        /// </summary>
        public string CardPwd { set; get; }

        /// <summary>
        /// 卡密过期时间
        /// </summary>
        public DateTime CardDearLine { set; get; }
    }
}
