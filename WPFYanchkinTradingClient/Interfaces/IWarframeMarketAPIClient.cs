using Refit;
using System.Threading.Tasks;
using WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetAllItems;
using WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemInfo;
using WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders;

namespace WPFYanchkinTradingClient.Interfaces
{
    /// <summary>
    /// Интерфейс клиента Warframe Market API
    /// </summary>
    public interface IWarframeMarketAPIClient
    {
        /// <summary>
        /// Получение перечня всех предметов
        /// </summary>
        /// <returns></returns>
        [Get("/items")]
        Task<GetAllItemsResponceDC> GetAllItems();

        /// <summary>
        /// Получение перечня всех предметов
        /// </summary>
        /// <returns></returns>
        [Get("/items/{urlName}")]
        Task<GetItemInfoResponceDC> GetItemInfo(string urlName);

        /// <summary>
        /// Получение заказов по предмету
        /// </summary>
        /// <returns></returns>
        [Get("/items/{urlName}/orders")]
        Task<GetItemOrdersResponceDC> GetItemOrders(string urlName, [Header("Platform")] string platform="pc" );
    }
}
