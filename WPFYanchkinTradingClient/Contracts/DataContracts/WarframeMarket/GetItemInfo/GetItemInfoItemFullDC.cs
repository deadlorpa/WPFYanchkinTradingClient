using Refit;
using System.Collections.Generic;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemInfo
{
    /// <summary>
    /// Полный контракт предмета GetItemInfo
    /// </summary>
    public class GetItemInfoItemFullDC
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// URL в API
        /// </summary>
        [AliasAs("url_name")]
        public string UrlName { get; set; }

        /// <summary>
        /// Путь к иконке
        /// </summary>
        [AliasAs("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Формат иконки
        /// </summary>
        [AliasAs("icon_format")]
        public string IconFormat { get; set; }

        /// <summary>
        /// Эскиз
        /// </summary>
        [AliasAs("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// Сопутствующая иконка
        /// </summary>
        [AliasAs("sub_icon")]
        public string SubIcon { get; set; }

        /// <summary>
        /// Максимальный ранг (для модов)
        /// </summary>
        [AliasAs("mod_max_rank")]
        public int ModMaxRank { get; set; }

        /// <summary>
        /// Подтипы
        /// </summary>
        [AliasAs("subtypes")]
        public IEnumerable<string> SubTypes { get; set; }

        /// <summary>
        /// Тэги
        /// </summary>
        [AliasAs("tags")]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// Дукаты
        /// </summary>
        [AliasAs("ducats")]
        public int Ducats { get; set; }

        /// <summary>
        /// Кол-во в сете
        /// </summary>
        [AliasAs("quantity_for_set")]
        public int QuantityForSet { get; set; }

        /// <summary>
        /// Признак ядра сета
        /// </summary>
        [AliasAs("set_root")]
        public bool SetRoot { get; set; }

        /// <summary>
        /// Требование к уровню мастерства
        /// </summary>
        [AliasAs("mastery_level")]
        public int MasteryLevel { get; set; }

        /// <summary>
        /// Редкость
        /// </summary>
        [AliasAs("rarity")]
        public string Rarity { get; set; }

        /// <summary>
        /// Налог при обмене
        /// </summary>
        [AliasAs("trading_tax")]
        public int TradingTax { get; set; }

        /// <summary>
        /// Русское описание
        /// </summary>
        [AliasAs("ru")]
        public GetItemInfoLangInItemDC RU { get; set; }
    }
}
