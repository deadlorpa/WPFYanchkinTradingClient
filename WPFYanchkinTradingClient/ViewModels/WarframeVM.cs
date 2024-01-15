using Microsoft.VisualStudio.PlatformUI;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;
using WPFYanchkinTradingClient.Contracts.DTO;
using WPFYanchkinTradingClient.ModelLayer;

namespace WPFYanchkinTradingClient.ViewModels
{
    public class WarframeVM : ObservableObject
    {
        private WarframeModel _warframeModel;

        private string _searchPattern;
        public string SearchPattern
        {
            get => _searchPattern;
            set
            {
                SetProperty(ref _searchPattern, value);
                if (string.IsNullOrEmpty(value))
                {
                    Warframes = _reservedWarframes;
                }
                else
                {
                    Warframes = new ObservableCollection<WarframeDTO>(
                    _reservedWarframes.Where(x => x.Name.ToLower().StartsWith(SearchPattern.ToLower()))
                    );
                }
            }
        }

        private ObservableCollection<WarframeDTO> _reservedWarframes;
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
            _reservedWarframes = Warframes;
        }
    }
}
