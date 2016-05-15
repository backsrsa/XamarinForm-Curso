using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MyOrders.Services;

namespace MyOrders.ViewModels
{
    public class MenuItemViewModel
    {
        private readonly NavigationService _navigationService;

        public MenuItemViewModel()
        {
            _navigationService=new NavigationService();
        }

        #region Propiedades

        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        #endregion

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(()=>_navigationService.Navigate(PageName));
            }
        }

    }
}
