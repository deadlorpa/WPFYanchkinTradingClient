using Refit;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders
{
    /// <summary>
    /// Содержимое GetItemOrders
    /// </summary>
    public class GetItemOrdersPayloadDC
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("platinum")]
        public int Platinum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("creation_date")]
        public string CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("last_update")]
        public string LastUpdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("subtype")]
        public string SubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("user")]
        public GetItemOrdersUserDC User { get; set; }
    }
}
