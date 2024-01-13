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
        public ObservableCollection<WarframeDTO> GetWarframes()
        {
            var itemsResponce = WarframeMarketAPIClient.GetAllItems().Result;

            //var warframes = new ObservableCollection<WarframeDTO>();
            //foreach ( var item in itemsResponce.Payload.Items)
            //{
            //    warframes.Add(new WarframeDTO()
            //    {
            //        Url = item.UrlName,
            //        Name = item.ItemName,
            //        IconPath = App.Config.GetSection("WarframeMarketAssets").Value + item.Thumb
            //    });
            //}
            var warframes = new ObservableCollection<WarframeDTO>()
            {
                new WarframeDTO()
                {
                    Url = "loki_prime_set",
                    Name = "loki prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
                },
                 new WarframeDTO()
                {
                    Url = "loki_prime_set",
                    Name = "loki prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
                },
                  new WarframeDTO()
                {
                    Url = "loki_prime_set",
                    Name = "loki prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
                },
                   new WarframeDTO()
                {
                    Url = "loki_prime_set",
                    Name = "loki prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
                },
                    new WarframeDTO()
                {
                    Url = "loki_prime_set",
                    Name = "loki prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.loki_prime_set.abc05c280f92196bcb688643873fbf95.128x128.png"
                },
                new WarframeDTO()
                {
                    Url = "nekros_prime_set",
                    Name = "nekros prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.nekros_prime_set.523943a15c82985ebe7cf14eac98966d.128x128.png"
                }
            };
            return warframes;
        }
    }
}
