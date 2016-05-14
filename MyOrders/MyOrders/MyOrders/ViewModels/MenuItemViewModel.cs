using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MyOrders.Pages;

namespace MyOrders.ViewModels
{
    public class MenuItemViewModel
    {
        #region Propiedades

        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        #endregion

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }

        private void Navigate()
        {
            App.Master.IsPresented = false;//para cerrar el menu lateral
            switch (PageName)
            {
                case "AlarmsPage":
                    App.Navigator.PushAsync(new AlarmsPage());
                    break;

                case "ClientsPage":
                    App.Navigator.PushAsync(new ClientsPage());
                    break;

                case "SettingsPage":
                    App.Navigator.PushAsync(new SettingsPage());
                    break;

                case "MainPage":
                    App.Navigator.PopToRootAsync();
                    break;
            }
        }
    }
}
