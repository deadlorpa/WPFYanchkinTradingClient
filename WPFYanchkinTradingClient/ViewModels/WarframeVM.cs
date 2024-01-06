using Microsoft.VisualStudio.PlatformUI;
using System.Collections.ObjectModel;
using WPFYanchkinTradingClient.Contracts.DTO;
using WPFYanchkinTradingClient.ModelLayer;

namespace WPFYanchkinTradingClient.ViewModels
{
    public class WarframeVM : ObservableObject
    {
        private WarframeModel _warframeModel;

        private ObservableCollection<WarframeDTO> _warframes;
        /// <summary>
        /// Список варфреймов
        /// </summary>
        public ObservableCollection<WarframeDTO> Warframes
        {
            get => _warframes;
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
        }
    }
}
