using Refit;
using System.Collections.ObjectModel;
using WPFYanchkinTradingClient.Contracts.DTO;
using WPFYanchkinTradingClient.Helpers;
using WPFYanchkinTradingClient.Interfaces;

namespace WPFYanchkinTradingClient.ModelLayer
{
    /// <summary>
    /// Модель варфреймы
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
        /// Получение списка варфреймов
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<WarframeTradeItemDTO> GetWarframes()
        {
            var itemsResponce = WarframeMarketAPIClient.GetAllItems().Result;

            var warframes = new ObservableCollection<WarframeTradeItemDTO>();
            foreach (var item in itemsResponce.Payload.Items)
            {
                warframes.Add(new WarframeTradeItemDTO()
                {
                    Url = item.UrlName,
                    Name = item.ItemName,
                    IconPath = App.Config.GetSection("WarframeMarketAssets").Value + item.Thumb
                });
            }
            //for (var i = 0; i<20; i++)
            //{
            //    warframes.Add(new WarframeDTO()
            //    {
            //        Url = "loki_prime_set",
            //        Name = "loki prime",
            //        IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
            //    });
            //}
            //warframes.Add(new WarframeDTO()
            //{
            //    Url = "loki_prime_set",
            //    Name = "koki prime",
            //    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
            //});
            return warframes;
        }
    }
}
