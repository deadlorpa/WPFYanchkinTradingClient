using WPFYanchkinTradingClient.Contracts.Enums;

namespace WPFYanchkinTradingClient.Contracts.DTO
{
    /// <summary>
    /// Сделка
    /// </summary>
    public class DealDTO
    {
        /// <summary>
        /// Продавец
        /// </summary>
        public DealerDTO Dealer { get; set; }

        /// <summary>
        /// Тип сделки
        /// </summary>
        public DealTypes Type { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }
    }
}
