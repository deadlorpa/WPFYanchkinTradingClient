using WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders;
using WPFYanchkinTradingClient.Contracts.DTO;

namespace WPFYanchkinTradingClient.Contracts.Extensions
{
    /// <summary>
    /// Расширение Dealer
    /// </summary>
    public static class DealerExtensions
    {
        /// <summary>
        /// Получить <see cref="DealerDTO"/> из <see cref="GetItemOrdersUserDC"/>
        /// </summary>
        /// <param name="dc">Контракт пользователя</param>
        /// <returns><see cref="DealerDTO"/></returns>
        public static DealerDTO ToDealerDTO(this GetItemOrdersUserDC dc)
        {
            return new DealerDTO
            {
                Name = dc.IngameName,
                Status = DealerStatusesExtensions.FromWarframeMarket(dc.Status),
                Region = RegionsExtensions.FromWarframeMarket(dc.Locale)
            };
        }
    }
}
