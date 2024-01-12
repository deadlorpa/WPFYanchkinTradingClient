using Refit;
using System.Collections.Generic;

namespace WPFYanchkinTradingClient.Contracts.DataContracts.WarframeMarket.GetItemInfo
{
    /// <summary>
    /// Контракт локализации GetItemInfo 
    /// </summary>
    public class GetItemInfoLangInItemDC
    {
        /// <summary>
        /// Наименование предмета
        /// </summary>
        [AliasAs("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [AliasAs("description")]
        public string Description { get; set; }

        /// <summary>
        /// Ссылка на wiki
        /// </summary>
        [AliasAs("wiki_link")]
        public string WikiLink { get; set; }

        /// <summary>
        /// Дроп
        /// </summary>
        [AliasAs("drop")]
        public Dictionary<string, string> Drop { get; set; }
    }
}
