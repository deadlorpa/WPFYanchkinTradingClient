using System;
using WPFYanchkinTradingClient.Contracts.Enums;

namespace WPFYanchkinTradingClient.Contracts.Extensions
{
    /// <summary>
    /// Расширение DealTypes
    /// </summary>
    public static class DealTypesExtensions
    {
        /// <summary>
        /// Получить <see cref="DealTypes"/> из типа сделки Warframe Market
        /// </summary>
        /// <param name="dealType"></param>
        /// <returns><see cref="DealTypes"/></returns>
        public static DealTypes FromWarframeMarket(string dealType)
        {
            return Enum.TryParse(typeof(DealTypes), dealType, true, out object? result) ?
               (DealTypes)result : DealTypes.Unknown;
        }
    }
}
