using System.Collections.ObjectModel;
using WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders;
using WPFYanchkinTradingClient.Contracts.DTO;

namespace WPFYanchkinTradingClient.Contracts.Extensions
{
    /// <summary>
    /// Расширение Deals
    /// </summary>
    public static class DealExtensions
    {
        /// <summary>
        /// Получить коллекцию <see cref="DealDTO"/> из <see cref="GetItemOrdersResponceDC"/>
        /// </summary>
        /// <param name="dc"></param>
        /// <returns></returns>
        public static ObservableCollection<DealDTO> ToDealDTOs(this GetItemOrdersResponceDC dc)
        {
            var result = new ObservableCollection<DealDTO>();
            foreach (var order in dc.Payload.Orders)
            {
                result.Add(new DealDTO
                {
                    Dealer = order.User.ToDealerDTO(),
                    Type = DealTypesExtensions.FromWarframeMarket(order.OrderType),
                    Price = order.Platinum.Value
                });
            }
            return result;
        }
    }
}
