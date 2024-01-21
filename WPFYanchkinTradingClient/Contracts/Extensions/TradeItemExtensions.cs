using System.Collections.ObjectModel;
using WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetAllItems;
using WPFYanchkinTradingClient.Contracts.DTO.TradeItem;

namespace WPFYanchkinTradingClient.Contracts.Extensions
{
    /// <summary>
    /// Расширение TradeItem
    /// </summary>
    public static class TradeItemExtensions
    {
        /// <summary>
        /// Получить коллекцию <see cref="WarframeMarketTradeItemDTO"/> из <see cref="GetAllItemsResponceDC"/>
        /// </summary>
        /// <param name="dc"></param>
        /// <returns></returns>
        public static ObservableCollection<WarframeMarketTradeItemDTO> ToTradeItemDTOs(this GetAllItemsResponceDC dc)
        {
            var items = new ObservableCollection<WarframeMarketTradeItemDTO>();
            foreach (var item in dc.Payload.Items)
            {
                items.Add(new WarframeMarketTradeItemDTO()
                {
                    Url = item.UrlName,
                    Name = item.ItemName,
                    IconPath = App.Config.GetSection("WarframeMarketAssets").Value + item.Thumb
                });
            }
            return items;
        }
    }
}
