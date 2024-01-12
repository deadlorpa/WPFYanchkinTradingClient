using Refit;
using System.Collections.Generic;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemInfo
{
    /// <summary>
    /// Содержимое GetItemInfo
    /// </summary>
    public class GetItemInfoPayloadDC
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Набор предметов-компонентов
        /// </summary>
        [AliasAs("items_in_set")]
        public IEnumerable<GetItemInfoItemFullDC> Items { get; set; }
    }
}
