using Microsoft.VisualStudio.PlatformUI;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WPFYanchkinTradingClient.Contracts.DTO;
using WPFYanchkinTradingClient.ModelLayer;

namespace WPFYanchkinTradingClient.ViewModels
{
    public class WarframeVM : ObservableObject
    {
        private WarframeModel _warframeModel;

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
            var item = obj as WarframeTradeItemDTO;
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

        private ObservableCollection<WarframeTradeItemDTO> _warframeTradeItems;
        /// <summary>
        /// Список предметов торговли Warframe
        /// </summary>
        public ObservableCollection<WarframeTradeItemDTO> WarframeTradeItems
        {
            get => _warframeTradeItems ?? (_warframeTradeItems = new ObservableCollection<WarframeTradeItemDTO>());
            set => SetProperty(ref _warframeTradeItems, value);
        }

        private WarframeTradeItemDTO _selectedWarframeTradeItem;
        /// <summary>
        /// Выбранный предмет торговли Warframe
        /// </summary>
        public WarframeTradeItemDTO SelectedWarframeTradeItem
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

        public WarframeVM()
        {
            _warframeModel = new WarframeModel();
        }

        /// <summary>
        /// При загрузке вьюшки
        /// </summary>
        public void OnViewLoaded()
        {
            WarframeTradeItems = _warframeModel.GetTradeItems();
            ItemsCollection = CollectionViewSource.GetDefaultView(WarframeTradeItems);
            ItemsCollection.Filter = FilterItemsCollection;
        }

        /// <summary>
        /// При изменении выбранного предмета торговли
        /// </summary>
        public void OnSelectedTradeItemChanged()
        {
            Deals = _warframeModel.GetDeals(SelectedWarframeTradeItem.Url);
            DealsCollection = CollectionViewSource.GetDefaultView(Deals);
        }
    }
}
