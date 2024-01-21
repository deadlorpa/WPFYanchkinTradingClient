using Refit;
using System.Collections.Generic;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders
{
    /// <summary>
    /// Содержимое GetItemOrders
    /// </summary>
    public class GetItemOrdersPayloadDC
    {
        /// <summary>
        /// Заказы
        /// </summary>
        [AliasAs("orders")]
        public IEnumerable<GetItemOrdersOrderDC> Orders { get; set; }
    }
}
