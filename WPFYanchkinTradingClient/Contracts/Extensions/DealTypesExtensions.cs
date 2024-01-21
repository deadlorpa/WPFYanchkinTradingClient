using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Возвращает словарь <see cref="DealTypes"/>
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, DealTypes> ToDictionary()
        {
            var result = new Dictionary<string, DealTypes>();
            foreach(var dealType in Enum.GetValues(typeof(DealTypes)))
            {
                result.Add(dealType.ToString(), (DealTypes)dealType);
            }
            return result;
        }
    }
}
