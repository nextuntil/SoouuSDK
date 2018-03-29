using System;
using System.Collections.Generic;
using SoouuSDK.Common;
using SoouuSDK.Request;
using SoouuSDK.Response;

namespace SoouuSDK.Tests {
    class Program {
        public static void Main(string[] args) {
            ISoouuClient soouuClient = new DefaultSoouuClient("http://test.ccapi.soouu.cn/Interface/Method", "803683", "CC11F561EBF14204089A5C64DE61C8DF");
            //获取用户信息
            CustomerGetRequest customerGetRequest = new CustomerGetRequest();
            CustomerGetResponse customerGetResponse = soouuClient.Execute(customerGetRequest);
            Console.WriteLine(customerGetResponse.ToJson());
            //获取商品类目
            CatalogsGetRequest catalogsGetRequest = new CatalogsGetRequest();
            List<CatalogsGetResponse> catalogsGetResponse = soouuClient.QueryList(catalogsGetRequest);
            Console.WriteLine(catalogsGetResponse.ToJson());
            //获取商品列表
            GoodsGetRequest goodsGetRequest = new GoodsGetRequest { goodscatalogid = 1005};
            List<GoodsGetResponse> goodsGetResponse = soouuClient.QueryList(goodsGetRequest);
            Console.WriteLine(goodsGetResponse.ToJson());
            //话费直充
            PhoneOrderAddRequest phoneOrderAddRequest = new PhoneOrderAddRequest {
                chargephone = "18888888888",
                chargeparvalue = "50",
                customerorderno="XXX2Q3111",
                notifyurl = "http://www.baidu.com"
            };
            OrderAddResponse phoneOrderAddResponse = soouuClient.Execute(phoneOrderAddRequest);
            Console.WriteLine(phoneOrderAddResponse.ToJson());
            //流量直充
            TrafficGoodsAddRequest trafficGoodsAddRequest = new TrafficGoodsAddRequest {
                chargephone = "18888888888",
                chargeparvalue = "1024",
                areatype = "1",
                customerorderno = "123456",
                notifyurl = "http://www.baidu.com"
            };
            OrderAddResponse trafficGoodsAddResponse = soouuClient.Execute(phoneOrderAddRequest);
            Console.WriteLine(trafficGoodsAddResponse.ToJson());
            //网游直充
            OrderAddRequest orderAddRequest = new OrderAddRequest {
                customerorderno=DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                productid= 1204405,
                buyerip=HttpUtils.GetAddressIP(),
                chargeaccount= "18888888888",
                buynum=1
            };
            OrderAddResponse orderAddResponse = soouuClient.Execute(orderAddRequest);
            Console.WriteLine(orderAddResponse.ToJson());
            //卡密提卡
            CardOrderAddRequest cardOrderAddRequest = new CardOrderAddRequest {
                customerorderno = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                productid = 1204406,
                buynum = 1
            };
            CardOrderAddResponse cardOrderAddResponse = soouuClient.Execute(cardOrderAddRequest);
            Console.WriteLine(cardOrderAddResponse.ToJson());
        }
    }
}
