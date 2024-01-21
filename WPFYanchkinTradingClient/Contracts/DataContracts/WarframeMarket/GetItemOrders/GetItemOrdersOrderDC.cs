using Refit;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders
{
    /// <summary>
    /// Контракт заказа GetItemOrders
    /// </summary>
    public class GetItemOrdersOrderDC
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
        public int? Platinum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("order_type")]
        public string? OrderType { get; set; }

        /// <summary>
        /// Платформа
        /// </summary>
        [AliasAs("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("creation_date")]
        public string? CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AliasAs("last_update")]
        public string? LastUpdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[AliasAs("subtype")]
        //public string? SubType { get; set; }

        /// <summary>
        /// Видимость
        /// </summary>
        [AliasAs("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// Сдельщик
        /// </summary>
        [AliasAs("user")]
        public GetItemOrdersUserDC User { get; set; }
    }
}
