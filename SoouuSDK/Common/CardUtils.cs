using SoouuSDK.Response;
using System;
using System.Text;

namespace SoouuSDK.Common {
    /// <summary>
    /// 卡密取卡操作类
    /// </summary>
    public class CardUtils {

        /// <summary>
        /// 卡密取卡
        /// </summary>
        /// <param name="orderId">树鱼订单号</param>
        /// <param name="secret">密钥</param>
        /// <param name="cardInfo">加密了的卡密对象</param>
        /// <returns></returns>
        public static CardInfo GetCardNumberAndPwd(string orderId, string secret, CardInfo cardInfo) {
            string key = StringUtils.Md5Hash(orderId + secret).Substring(4, 8);
            cardInfo.CardNumber = DESDecrypt(cardInfo.CardNumber, key);
            cardInfo.CardPwd = DESDecrypt(cardInfo.CardPwd, key);
            return cardInfo;
        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="input">待解密字串</param>
        /// <param name="key">解密key</param>
        /// <returns></returns>
        private static string DESDecrypt(string input, string key) {
            System.Security.Cryptography.DESCryptoServiceProvider des = new System.Security.Cryptography.DESCryptoServiceProvider();
            des.Key = Encoding.UTF8.GetBytes(key);
            des.IV = new byte[8];
            System.Security.Cryptography.ICryptoTransform cTransform = des.CreateDecryptor(des.Key, des.IV);
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            System.Security.Cryptography.CryptoStream cStream = new System.Security.Cryptography.CryptoStream(mStream, cTransform, System.Security.Cryptography.CryptoStreamMode.Write);
            byte[] byt = Convert.FromBase64String(input);
            cStream.Write(byt, 0, byt.Length);
            cStream.FlushFinalBlock();
            cStream.Close();
            return Encoding.UTF8.GetString(mStream.ToArray());
        }

    }
}
