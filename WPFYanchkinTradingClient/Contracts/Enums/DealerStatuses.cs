namespace WPFYanchkinTradingClient.Contracts.Enums
{
    /// <summary>
    /// Статусы сдельщика
    /// </summary>
    public enum DealerStatuses
    {
        /// <summary>
        /// Неизвестно
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Не в сети
        /// </summary>
        Offline = 1,
        /// <summary>
        /// В сети
        /// </summary>
        Online = 2,
        /// <summary>
        /// В игре
        /// </summary>
        InGame = 3
    }
}
