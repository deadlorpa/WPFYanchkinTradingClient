using Refit;
using System.Net.Http;
using System.Threading.Tasks;

namespace WPFYanchkinTradingClient.Interfaces
{
    public interface IWarframeMarketAssetsClient
    {
        /// <summary>
        /// Получение ответа ассетов
        /// </summary>
        /// <returns></returns>
        [Get("/{url}")]
        Task<HttpResponseMessage> GetImage(string url);
    }
}
