using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;

namespace SoouuSDK.Common {
    /// <summary>
    /// 字符串操作类
    /// </summary>
    public static class StringUtils {

        /// <summary>
        /// JSON序列化
        /// </summary>
        /// <param name="obj">待序列化的对象</param>
        /// <returns></returns>
        public static string ToJson(this object obj) {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(obj);
        }

        /// <summary>
        /// JSON反序列化
        /// </summary>
        /// <typeparam name="T">反序列化数据类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <returns></returns>
        public static T JsonDeserialize<T>(this string json) {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Deserialize<T>(json);
        }

        /// <summary>
        /// md5加密
        /// </summary>
        /// <param name="oristring">待加密字串</param>
        /// <returns></returns>
        public static string Md5Hash(string oristring) {
            byte[] bytes;
            MD5 md5 = MD5.Create();
            bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(oristring));
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++) {
                result.Append(bytes[i].ToString("x2"));
            }
            return result.ToString();
        }

    }
}
