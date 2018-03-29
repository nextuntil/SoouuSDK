using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace SoouuSDK.Common {
    /// <summary>
    /// HTTP请求操作类
    /// </summary>
    public class HttpUtils {

        /// <summary>
        /// 发起HTTP GET请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="errmsg">错误信息</param>
        /// <param name="parameters">请求参数</param>
        /// <param name="timeoutSeconds">超时时间</param>
        /// <returns></returns>
        public static string Get(string url, out string errmsg, Dictionary<string, object> parameters, int timeoutSeconds = 10) {
            string result = null;
            errmsg = null;
            var strUrl = new StringBuilder(url);
            if (parameters != null && parameters.Count > 0) {
                //拼接参数
                strUrl.Append("?");
                foreach (KeyValuePair<string, object> keyValuePair in parameters) {
                    strUrl.AppendFormat($"{keyValuePair.Key}={keyValuePair.Value}&");
                }
                strUrl.Remove(strUrl.Length - 1, 1);//移除最后一位多出的“&”
            }
            var request = (HttpWebRequest)WebRequest.Create(strUrl.ToString());
            request.ContentType = "text/html;charset=UTF-8";
            request.Method = "GET";
            request.ReadWriteTimeout = timeoutSeconds * 1000;
            try {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                    using (Stream stream = response.GetResponseStream()) {
                        if (stream != null) {
                            var reader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
                            result = reader.ReadToEnd();
                            reader.Dispose();
                            stream.Dispose();
                        }
                    }
                }
            } catch (Exception ex) {
                errmsg = "请求异常：" + ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 获取签名：依据参数和私钥
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        public static string SignRequest(IDictionary<string, object> parameters, string secret) {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, object> sortedParams = new SortedDictionary<string, object>(parameters, StringComparer.Ordinal);
            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder();
            foreach (KeyValuePair<string, object> kv in sortedParams) {
                if (!string.IsNullOrEmpty(kv.Key) && kv.Value != null) {
                    query.Append(kv.Key).Append("=").Append(kv.Value).Append("&");
                }
            }
            string postData = query.ToString().TrimEnd('&');
            // 第三步：把秘钥拼接在参数后面
            postData += secret;
            // 第四步：使用MD5加密
            return StringUtils.Md5Hash(postData);
        }

        /// <summary>
        /// 获取本地IP地址信息
        /// </summary>
        public static string GetAddressIP() {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList) {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork") {
                    AddressIP = _IPAddress.ToString();
                }
            }
            return AddressIP;
        }

    }
}
