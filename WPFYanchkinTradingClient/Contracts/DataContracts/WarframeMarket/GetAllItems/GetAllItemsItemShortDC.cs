using Newtonsoft.Json;
using Refit;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetAllItems
{
    /// <summary>
    /// Короткий контракт Item
    /// </summary>
    public class GetAllItemsItemShortDC
    {
        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// URL в API
        /// </summary>
        [JsonProperty(PropertyName= "url_name")]
        [AliasAs("url_name")]
        public string UrlName { get; set; }

        /// <summary>
        /// Путь к картинке в API
        /// </summary>
        [AliasAs("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [AliasAs("item_name")]
        public string ItemName { get; set; }
    }
}
