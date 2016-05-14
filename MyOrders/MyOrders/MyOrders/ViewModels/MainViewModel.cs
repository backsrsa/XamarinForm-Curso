using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrders.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            LoadMenu();
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel()
                {
                    Icon = "ic_action_orders",
                    Title = "Orders",
                    PageName = "NewOrderPage"
                },
                new MenuItemViewModel()
                {
                    Icon = "ic_action_clients",
                    Title = "Clients",
                    PageName = "ClientsPage"
                },
                new MenuItemViewModel()
                {
                    Icon = "ic_action_alarm",
                    Title = "Alarm",
                    PageName = "AlarmsPage"
                },
                new MenuItemViewModel()
                {
                    Icon = "ic_action_settings",
                    Title = "Settings",
                    PageName = "SettingsPage"
                }
            };
        }

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
    }
}
