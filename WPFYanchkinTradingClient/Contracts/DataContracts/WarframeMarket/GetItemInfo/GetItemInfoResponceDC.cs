using Refit;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemInfo
{
    /// <summary>
    /// Контракт ответа GetItemInfo
    /// </summary>
    public class GetItemInfoResponceDC
    {
        /// <summary>
        /// Содержимое ответа
        /// </summary>
        [AliasAs("payload")]
        public GetItemInfoPayloadDC Payload { get; set; }
    }
}
