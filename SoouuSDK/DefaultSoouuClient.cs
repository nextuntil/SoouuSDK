using SoouuSDK.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SoouuSDK {
    public class DefaultSoouuClient : ISoouuClient {

        /// <summary>
        /// 请求地址
        /// </summary>
        private string url;

        /// <summary>
        /// 接入商户ID
        /// </summary>
        private string customerId;

        /// <summary>
        /// 密钥
        /// </summary>
        private string secret;

        /// <summary>
        /// 返回数据格式
        /// </summary>
        private string format;


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="customerId">接入商户ID</param>
        /// <param name="secret">密钥</param>
        /// <param name="format">返回数据格式</param>
        public DefaultSoouuClient(string url, string customerId, string secret, string format = "json") {
            this.url = url;
            this.customerId = customerId;
            this.secret = secret;
            this.format = format;
        }

        /// <summary>
        /// 请求API返回实体对象
        /// </summary>
        /// <typeparam name="T">请求参数类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <returns></returns>
        public T Execute<T>(ISoouuRequest<T> request) where T : SoouuResponse {
            string message;
            Dictionary<string, object> parameters = BuildParams(request);
            string sign = HttpUtils.SignRequest(parameters, secret);
            parameters.Add("sign", sign);
            string result = HttpUtils.Get(url, out message, parameters, 10);
            T t = result.JsonDeserialize<T>();
            return t;
        }

        /// <summary>
        /// 请求API返回数据列表
        /// </summary>
        /// <typeparam name="T">请求参数类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <returns></returns>
        public List<T> QueryList<T>(ISoouuRequest<T> request) where T : SoouuResponse {
            string message;
            Dictionary<string, object> parameters = BuildParams(request);
            string sign = HttpUtils.SignRequest(parameters, secret);
            parameters.Add("sign", sign);
            string result = HttpUtils.Get(url, out message, parameters, 10);
            List<T> t = result.JsonDeserialize<List<T>>();
            return t;
        }

        /// <summary>
        /// 构建请求参数
        /// </summary>
        /// <typeparam name="T">请求参数类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <returns></returns>
        private Dictionary<string, object> BuildParams<T>(ISoouuRequest<T> request) where T : SoouuResponse {
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                { "customerid", customerId },
                { "format",format},
                { "timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                { "v", "1.0" }
            };
            Type t = request.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo prop in props) {
                string pName = prop.Name;
                if (pName != "sign") {
                    object pValue = t.GetProperty(pName)?.GetValue(request);
                    if (!parameters.ContainsKey(pName) && !string.IsNullOrEmpty(pValue?.ToString())) {
                        parameters.Add(pName, pValue);
                    }
                }
            }
            return parameters;
        }
    }
}
