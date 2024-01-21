using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Возвращает словарь <see cref="DealerStatuses"/>
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, DealerStatuses> ToDictionary()
        {
            var result = new Dictionary<string, DealerStatuses>();
            foreach (var dealerStatus in Enum.GetValues(typeof(DealerStatuses)))
            {
                result.Add(dealerStatus.ToString(), (DealerStatuses)dealerStatus);
            }
            return result;
        }
    }
}
