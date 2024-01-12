using Refit;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders
{
    /// <summary>
    /// Контракт ответа GetItemOrders
    /// </summary>
    public class GetItemOrdersResponceDC
    {
        /// <summary>
        /// Содержимое ответа
        /// </summary>
        [AliasAs("payload")]
        public GetItemOrdersPayloadDC Payload { get; set; }
    }
}
