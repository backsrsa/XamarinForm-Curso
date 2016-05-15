using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOrders.Pages;

namespace MyOrders.Services
{
    public class NavigationService
    {
        public async void Navigate(string PageName)
        {
            App.Master.IsPresented = false;//para cerrar el menu lateral
            switch (PageName)
            {
                case "AlarmsPage":
                    await App.Navigator.PushAsync(new AlarmsPage());
                    break;

                case "ClientsPage":
                    await App.Navigator.PushAsync(new ClientsPage());
                    break;

                case "SettingsPage":
                    await App.Navigator.PushAsync(new SettingsPage());
                    break;

                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
            }
        }

        

    }
}
