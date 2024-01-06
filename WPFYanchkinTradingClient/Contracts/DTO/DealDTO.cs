namespace WPFYanchkinTradingClient.Contracts.DTO
{
    /// <summary>
    /// Сделка
    /// </summary>
    public class DealDTO
    {
        /// <summary>
        /// Имя продавца
        /// </summary>
        public string DealerName { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public string Region { get; set; }
    }
}
