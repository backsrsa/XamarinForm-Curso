using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MyOrders.Pages;
using MyOrders.Services;
using MyOrders.ViewModels;

namespace MyOrders.ViewModels
{
    public class MainViewModel
    {
        private NavigationService _navigationService;
        private ApiService apiService;
        #region Propiedades

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<OrderViewModel> Orders { get; set; }

        #endregion

        #region Metodos

        private void LoadData()
        {
            Orders = new ObservableCollection<OrderViewModel>();
            for (int i = 0; i < 5; i++)
            {
                Orders.Add(new OrderViewModel()
                {
                    Title = "Lorem Ipsum",
                    DeliveryDate = DateTime.Today,
                    Description = "Lorem Ipsum dolor sit amet, cosectetur adipiscing elit."
                });
            }
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel()
                {
                    Icon = "ic_action_orders",
                    Title = "Orders",
                    PageName = "MainPage"
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



        #endregion

        #region Commands

        public ICommand GoToCommand
        {
            get
            {
                { return new RelayCommand<string>(GoTo); }
            }

        }
        private void GoTo(string pageName)
        {
            switch (pageName)
            {
                case "NewOrderPage":
                    NewOrder = new OrderViewModel();
                    break;
            }
            _navigationService.Navigate(pageName);
        }

        public OrderViewModel NewOrder { get; set; }

        public ICommand StartCommand
        {
            get
            {
                return new RelayCommand(Start);
            }
        }

        private async void Start()
        {
            var list = await apiService.GetAllOrders();
            Orders.Clear();
            foreach (var order in list)
            {
                Orders.Add(new OrderViewModel()
                {
                    Title = order.Title,
                    DeliveryDate = order.DeliveryDate,
                    Description = order.Description
                });
            }

            _navigationService.SetMainPage("MasterPage");
        }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            Orders = new ObservableCollection<OrderViewModel>();
            _navigationService = new NavigationService();
            apiService = new ApiService();

            LoadMenu();
            //  LoadData();
        }

        #endregion

    }
}
