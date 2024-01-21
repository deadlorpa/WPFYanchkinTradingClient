using System;
using System.Collections.Generic;
using WPFYanchkinTradingClient.Contracts.Enums;

namespace WPFYanchkinTradingClient.Contracts.Extensions
{
    /// <summary>
    /// Расширение Regions
    /// </summary>
    public static class RegionsExtensions
    {
        /// <summary>
        /// Получить <see cref="Regions"/> из региона Warframe Market 
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public static Regions FromWarframeMarket(string region)
        {
            return Enum.TryParse(typeof(Regions), region, true, out object? result) ? 
                (Regions)result : Regions.Unknown;
        }

        /// <summary>
        /// Получить словарь <see cref="Regions"/>
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Regions> ToDictionary()
        {
            var result = new Dictionary<string, Regions>();
            foreach(var dealType in Enum.GetValues(typeof(Regions)))
            {
                result.Add(dealType.ToString(), (Regions) dealType);
    }
            return result;
        }
    }
}
