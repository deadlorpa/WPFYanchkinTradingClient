using Refit;
using System.Collections.ObjectModel;
using System.Windows;
using WPFYanchkinTradingClient.Contracts.DTO;
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
        public ObservableCollection<WarframeTradeItemDTO> GetTradeItems()
        {
            var items = new ObservableCollection<WarframeTradeItemDTO>();
#if DEBUG
            for (var i = 0; i < 20; i++)
            {
                items.Add(new WarframeTradeItemDTO()
                {
                    Url = "loki_prime_set",
                    Name = "loki prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
                });
            }
#else
            var itemsResponce = WarframeMarketAPIClient.GetAllItems().Result;
            foreach (var item in itemsResponce.Payload.Items)
            {
                warframes.Add(new WarframeTradeItemDTO()
                {
                    Url = item.UrlName,
                    Name = item.ItemName,
                    IconPath = App.Config.GetSection("WarframeMarketAssets").Value + item.Thumb
                });
            }
#endif
            return items;
        }

        /// <summary>
        /// Получить информацию о предмете торговли
        /// </summary>
        /// <param name="itemUrl"></param>
        /// <returns></returns>
        public ObservableCollection<WarframeTradeItemInfoDTO> GetTradeItemInfo(string itemUrl)
        {
            var itemInfo = new ObservableCollection<WarframeTradeItemInfoDTO>();
            // TODO: реализовать обмен
            return itemInfo; 
        }

        /// <summary>
        /// Получить сделки
        /// </summary>
        /// <param name="itemUrl"></param>
        /// <returns></returns>
        public ObservableCollection<DealDTO> GetDeals(string itemUrl) 
        { 
            var deals = new ObservableCollection<DealDTO>();
#if DEBUG
            for (int i = 0; i< 5; i++)
            {
                deals.Add(new DealDTO()
                {
                    Dealer = new DealerDTO()
                    {
                        Name = "Loo",
                        Status = Contracts.Enums.DealerStatuses.Online,
                        Region = Contracts.Enums.Regions.Ru
                    },
                    DealTypes = Contracts.Enums.DealTypes.Buy,
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
                    DealTypes = Contracts.Enums.DealTypes.Buy,
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
                    DealTypes = Contracts.Enums.DealTypes.Sell,
                    Price = i * 10
                });
            }
#else
            // TODO: реализовать обмен
#endif
            return deals; 
        }
    }
}
