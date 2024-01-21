using Refit;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemOrders
{
    /// <summary>
    /// Контракт пользователя GetItemOrders
    /// </summary>
    public class GetItemOrdersUserDC
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Внутриигровое имя
        /// </summary>
        [AliasAs("ingame_name")]
        public string? IngameName { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        [AliasAs("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        [AliasAs("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Локаль
        /// </summary>
        [AliasAs("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Репутация
        /// </summary>
        [AliasAs("reputation")]
        public int? Reputation { get; set; }

        /// <summary>
        /// Аватар
        /// </summary>
        [AliasAs("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Последний онлайн
        /// </summary>
        [AliasAs("last_seen")]
        public string? LastSeen { get; set; }
    }
}
