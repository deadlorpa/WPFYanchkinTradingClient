using Refit;
using System.Collections.Generic;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetAllItems
{
    /// <summary>
    /// Содержимое GetAllItems
    /// </summary>
    public class GetAllItemsPayload
    {
        /// <summary>
        /// Набор предметов
        /// </summary>
        [AliasAs("items")]
        public IEnumerable<GetAllItemsItemShortDC> Items { get; set; }
    }
}
