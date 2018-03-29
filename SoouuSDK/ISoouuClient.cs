using System.Collections.Generic;

namespace SoouuSDK {
    public interface ISoouuClient {

        /// <summary>
        /// 执行常规API（订单等）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        T Execute<T>(ISoouuRequest<T> request) where T : SoouuResponse;

        /// <summary>
        /// 公共查询API
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        List<T> QueryList<T>(ISoouuRequest<T> request) where T : SoouuResponse;
    }
}
