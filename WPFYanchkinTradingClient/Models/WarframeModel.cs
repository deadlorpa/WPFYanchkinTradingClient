using Refit;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WPFYanchkinTradingClient.Contracts.DTO;
using WPFYanchkinTradingClient.Contracts.DTO.TradeItem;
using WPFYanchkinTradingClient.Contracts.Extensions;
using WPFYanchkinTradingClient.Helpers;
using WPFYanchkinTradingClient.Interfaces;

namespace WPFYanchkinTradingClient.ModelLayer
{
    /// <summary>
    /// Модель Warframe
    /// </summary>
    public class WarframeModel
    {
        private IWarframeMarketAPIClient _warframeMarketAPIClient;
        /// <summary>
        /// Клиент Warframe Market API
        /// </summary>
        private IWarframeMarketAPIClient WarframeMarketAPIClient
        {
            get => _warframeMarketAPIClient ??
                (_warframeMarketAPIClient = 
                RestService.For<IWarframeMarketAPIClient>
                (App.Config.GetSection("WarframeMarketAPI").Value, RefitSettingsConfigurations.WarframeMarketConfiguration));
        }

        public WarframeModel() { }

        /// <summary>
        /// Получить список предметов торговли
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<WarframeMarketTradeItemDTO>> GetTradeItems()
        {
#if DEBUG
            var items = new ObservableCollection<WarframeMarketTradeItemDTO>();
            items.Add(new WarframeMarketTradeItemDTO()
            {
                Url = "mirage_prime_systems",
                Name = "Mirage",
                IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.mirage_prime_set.e7f8f484dd6ae6c35f0767fff35a5109.128x128.png"
            });
            items.Add(new WarframeMarketTradeItemDTO()
            {
                Url = "loki_prime_set",
                Name = "loki",
                IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
            });
#else
            var itemsResponce = await WarframeMarketAPIClient.GetAllItems();
            var items = itemsResponce.ToTradeItemDTOs();
#endif
            return items;
        }

        /// <summary>
        /// Получить информацию о предмете торговли
        /// </summary>
        /// <param name="itemUrl"></param>
        /// <returns></returns>
        public async Task<ObservableCollection<WarframeMarketTradeItemInfoDTO>> GetTradeItemInfo(string itemUrl)
        {
            var itemInfo = new ObservableCollection<WarframeMarketTradeItemInfoDTO>();
            // TODO: реализовать обмен
            return itemInfo; 
        }

        /// <summary>
        /// Получить сделки
        /// </summary>
        /// <param name="itemUrl"></param>
        /// <returns></returns>
        public async Task<ObservableCollection<DealDTO>> GetDeals(string itemUrl) 
        {
#if DEBUG
            var deals = new ObservableCollection<DealDTO>();
            for (int i = 0; i < 5; i++)
            {
                deals.Add(new DealDTO()
                {
                    Dealer = new DealerDTO()
                    {
                        Name = "Loo",
                        Status = Contracts.Enums.DealerStatuses.Online,
                        Region = Contracts.Enums.Regions.Ru
                    },
                    Type = Contracts.Enums.DealTypes.Buy,
                    Price = i * 10
                });
            }
            for (int i = 0; i < 5; i++)
            {
                deals.Add(new DealDTO()
                {
                    Dealer = new DealerDTO()
                    {
                        Name = "DeadLorpa",
                        Status = Contracts.Enums.DealerStatuses.Offline,
                        Region = Contracts.Enums.Regions.Ru
                    },
                    Type = Contracts.Enums.DealTypes.Buy,
                    Price = i * 10
                });
            }
            for (int i = 0; i < 5; i++)
            {
                deals.Add(new DealDTO()
                {
                    Dealer = new DealerDTO()
                    {
                        Name = "CuteLorpa",
                        Status = Contracts.Enums.DealerStatuses.InGame,
                        Region = Contracts.Enums.Regions.Ru
                    },
                    Type = Contracts.Enums.DealTypes.Sell,
                    Price = i * 10
                });
            }
#else
            var dealsResponce = await _warframeMarketAPIClient.GetItemOrders(itemUrl);
            var deals = dealsResponce.ToDealDTOs();
#endif
            return deals; 
        }
    }
}
