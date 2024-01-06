using System.Collections.ObjectModel;
using WPFYanchkinTradingClient.Contracts.DTO;

namespace WPFYanchkinTradingClient.ModelLayer
{
    public class WarframeModel
    {
        public WarframeModel() { }

        /// <summary>
        /// Получение списка варфреймов
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<WarframeDTO> GetWarframes()
        {
            // TODO: Переписать на обращение к АПИ/Датаконтексту
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
                    Url = "nekros_prime_set",
                    Name = "nekros prime",
                    IconPath = "C:\\Users\\Public\\Warframe Parser Icons\\items.images.en.thumbs.nekros_prime_set.523943a15c82985ebe7cf14eac98966d.128x128.png"
                }
            };
            return warframes;
        }
    }
}
