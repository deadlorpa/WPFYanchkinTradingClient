using System;
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
    }
}
