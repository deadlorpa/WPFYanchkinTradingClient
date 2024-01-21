using Refit;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace WPFYanchkinTradingClient.Helpers
{
    /// <summary>
    /// Конфиги RefitSettings
    /// </summary>
    public static class RefitSettingsConfigurations
    {
        /// <summary>
        /// Конфиг для Warframe Market
        /// </summary>
        /// <returns></returns>
        public static RefitSettings WarframeMarketConfiguration
            => new RefitSettings
            {
                ContentSerializer = new SystemTextJsonContentSerializer(
                    new JsonSerializerOptions()
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                        NumberHandling = JsonNumberHandling.AllowReadingFromString,
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                    })
            };
    }
}
