using Refit;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetAllItems
{
    /// <summary>
    /// Контракт ответа GetAllItems
    /// </summary>
    public class GetAllItemsResponceDC
    {
        /// <summary>
        /// Содержимое ответа
        /// </summary>
        [AliasAs("payload")]
        public GetAllItemsPayload Payload { get; set; }
    }
}
