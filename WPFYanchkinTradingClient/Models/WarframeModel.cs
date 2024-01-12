using Refit;
using System.Collections.ObjectModel;
using WPFYanchkinTradingClient.Contracts.DTO;
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
                (App.Config.GetSection("WarframeMarketAPI").Value));
        }

        public WarframeModel() { }

        /// <summary>
        /// Получение списка варфреймов
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<WarframeDTO> GetWarframes()
        {
            var itemsResponce = WarframeMarketAPIClient.GetAllItems().Result;

            var warframes = new ObservableCollection<WarframeDTO>();
            foreach ( var item in itemsResponce.Payload.Items)
            {
                warframes.Add(new WarframeDTO()
                {
                    Url = item.UrlName,
                    Name = item.ItemName,
                    IconPath = App.Config.GetSection("WarframeMarketAssets").Value + item.Thumb
                });
            }
            return warframes;
        }
    }
}
