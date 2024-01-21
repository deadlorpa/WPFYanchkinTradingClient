using Microsoft.VisualStudio.PlatformUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WPFYanchkinTradingClient.Contracts.DTO;
using WPFYanchkinTradingClient.Contracts.DTO.TradeItem;
using WPFYanchkinTradingClient.Contracts.Enums;
using WPFYanchkinTradingClient.Contracts.Extensions;
using WPFYanchkinTradingClient.ModelLayer;

namespace WPFYanchkinTradingClient.ViewModels
{
    public class WarframeVM : ObservableObject
    {
        private WarframeModel _warframeModel;

        #region Dictionaries
        private Dictionary<string, DealTypes> _dealTypesDictionary;
        public Dictionary<string, DealTypes> DealTypesDictionary 
        {
            get => _dealTypesDictionary;
            set => SetProperty(ref _dealTypesDictionary, value);
        }

        #endregion

        #region Search
        private string _searchPattern;
        /// <summary>
        /// Шаблон поиска
        /// </summary>
        public string SearchPattern
        {
            get => _searchPattern;
            set
            {
                SetProperty(ref _searchPattern, value);
                ItemsCollection.Refresh();
            }
        }

        /// <summary>
        /// Фильтр по поиску
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool FilterItemsCollection(object obj)
        {
            var item = obj as WarframeMarketTradeItemDTO;
            if (string.IsNullOrEmpty(_searchPattern))
                return true;
            return item.Name.ToLower().Contains(_searchPattern.ToLower());
        }
        #endregion

        #region Warframe Trade Items
        private ICollectionView _itemsCollection;
        /// <summary>
        /// Коллекция предметов торговли Warframe для отображения
        /// </summary>
        public ICollectionView ItemsCollection
        {
            get => _itemsCollection;
            set => SetProperty(ref _itemsCollection, value);
        }

        private ObservableCollection<WarframeMarketTradeItemDTO> _warframeTradeItems;
        /// <summary>
        /// Список предметов торговли Warframe
        /// </summary>
        public ObservableCollection<WarframeMarketTradeItemDTO> WarframeTradeItems
        {
            get => _warframeTradeItems ?? (_warframeTradeItems = new ObservableCollection<WarframeMarketTradeItemDTO>());
            set => SetProperty(ref _warframeTradeItems, value);
        }

        private WarframeMarketTradeItemDTO _selectedWarframeTradeItem;
        /// <summary>
        /// Выбранный предмет торговли Warframe
        /// </summary>
        public WarframeMarketTradeItemDTO SelectedWarframeTradeItem
        {
            get => _selectedWarframeTradeItem;
            set
            {
                SetProperty(ref _selectedWarframeTradeItem, value);
                if(_selectedWarframeTradeItem != null)
                    OnSelectedTradeItemChanged();
            }
        }
        #endregion

        #region Deals
        private ICollectionView _dealsCollection;
        /// <summary>
        /// Коллекция сделок Warframe для отображения
        /// </summary>
        public ICollectionView DealsCollection
        {
            get => _dealsCollection;
            set => SetProperty(ref _dealsCollection, value);
        }

        private ObservableCollection<DealDTO> _deals;
        /// <summary>
        /// Сделки Warframe
        /// </summary>
        public ObservableCollection<DealDTO> Deals
        {
            get => _deals ?? (_deals = new ObservableCollection<DealDTO>());
            set => SetProperty(ref _deals, value);
        }
        #endregion

        #region Deals Filters
        /// <summary>
        /// Фильтр коллеции сделок
        /// </summary>
        /// <param name="dealObject"></param>
        /// <returns></returns>
        private bool FilterDealsCollection(object dealObject)
        {
            var deal = (DealDTO)dealObject;
            return FilterDealType(deal.Type);
        }

        private string _filteredDealType;
        /// <summary>
        /// Фильтр типа сделки
        /// </summary>
        public string FilteredDealType
        {
            get => _filteredDealType;
            set
            {
                SetProperty(ref _filteredDealType, value);
                if(DealsCollection != null)
                    DealsCollection.Refresh();
            }
        }

        /// <summary>
        /// Ответ фильтра типа сделки
        /// </summary>
        /// <param name="dealType"></param>
        /// <returns></returns>
        private bool FilterDealType(DealTypes dealType)
        {
            if (string.IsNullOrEmpty(_filteredDealType) || _filteredDealType==DealTypes.Unknown.ToString())
                return true;
            return DealTypesDictionary[_filteredDealType] == dealType;
        }
        #endregion

        public WarframeVM()
        {
            _warframeModel = new WarframeModel();
        }

        /// <summary>
        /// При загрузке вьюшки
        /// </summary>
        public async void OnViewLoaded()
        {
            DealTypesDictionary = DealTypesExtensions.ToDictionary();
            WarframeTradeItems = await _warframeModel.GetTradeItems();
            ItemsCollection = CollectionViewSource.GetDefaultView(WarframeTradeItems);
            ItemsCollection.Filter = FilterItemsCollection;
        }

        /// <summary>
        /// При изменении выбранного предмета торговли
        /// </summary>
        public async void OnSelectedTradeItemChanged()
        {
            Deals = await _warframeModel.GetDeals(SelectedWarframeTradeItem.Url);
            DealsCollection = CollectionViewSource.GetDefaultView(Deals);
            DealsCollection.Filter = FilterDealsCollection;
        }
    }
}
