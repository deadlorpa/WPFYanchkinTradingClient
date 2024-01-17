using Microsoft.VisualBasic;
using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using System.Xml.Linq;
using WPFYanchkinTradingClient.Contracts.DTO;
using WPFYanchkinTradingClient.ModelLayer;

namespace WPFYanchkinTradingClient.ViewModels
{
    public class WarframeVM : ObservableObject
    {
        private WarframeModel _warframeModel;

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

        private ICollectionView _itemsCollection;
        /// <summary>
        /// Коллекция предметов
        /// </summary>
        public ICollectionView ItemsCollection
        {
            get => _itemsCollection;
            set => SetProperty(ref _itemsCollection, value);
        }

        private ObservableCollection<WarframeDTO> _warframes;
        /// <summary>
        /// Список варфреймов
        /// </summary>
        public ObservableCollection<WarframeDTO> Warframes
        {
            get => _warframes ?? (_warframes = new ObservableCollection<WarframeDTO>());
            set => SetProperty(ref _warframes, value);
        }

        private WarframeDTO _selectedWarframe;
        /// <summary>
        /// Выбранный варфрейм
        /// </summary>
        public WarframeDTO SelectedWarframe
        {
            get => _selectedWarframe;
            set => SetProperty(ref _selectedWarframe, value);
        }

        public WarframeVM()
        {
            _warframeModel = new WarframeModel();
        }

        /// <summary>
        /// При загрузке вьюшки
        /// </summary>
        public void OnViewLoaded()
        {
            Warframes = _warframeModel.GetWarframes();
            ItemsCollection = CollectionViewSource.GetDefaultView(Warframes);
            ItemsCollection.Filter = FilterItemsCollection;
        }

        /// <summary>
        /// Фильтр по поиску
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool FilterItemsCollection(object obj)
        {
            var item = obj as WarframeDTO;
            if (string.IsNullOrEmpty(_searchPattern))
                return true;
            return item.Name.ToLower().Contains(_searchPattern.ToLower());
        }
    }
}
