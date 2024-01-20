using WPFYanchkinTradingClient.Contracts.Enums;

namespace WPFYanchkinTradingClient.Contracts.DTO
{
    /// <summary>
    /// Сдельщик
    /// </summary>
    public class DealerDTO
    {
        /// <summary>
        /// Внутриигровое имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public DealerStatuses Status { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public Regions Region { get; set; }
    }
}
