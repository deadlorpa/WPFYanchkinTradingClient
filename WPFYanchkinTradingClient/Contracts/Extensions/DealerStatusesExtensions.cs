using System;
using WPFYanchkinTradingClient.Contracts.Enums;

namespace WPFYanchkinTradingClient.Contracts.Extensions
{
    /// <summary>
    /// Расшрешие DealerStatuses
    /// </summary>
    public static class DealerStatusesExtensions
    {
        /// <summary>
        /// Получить <see cref="DealerStatuses"/> из статуса на Warframe Market
        /// </summary>
        /// <param name="status"></param>
        /// <returns><see cref="DealerStatuses"/></returns>
        public static DealerStatuses FromWarframeMarket(string status)
        {
            return Enum.TryParse(typeof(DealerStatuses), status, true, out object? result) ?
               (DealerStatuses)result : DealerStatuses.Unknown;
        }
    }
}
