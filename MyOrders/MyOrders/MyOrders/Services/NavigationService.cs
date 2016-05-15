using System.Threading.Tasks;
using MyOrders.Pages;
using Xamarin.Forms;

namespace MyOrders.Services
{
    public class NavigationService
    {
        public async void Navigate(string pageName)
        {
            App.Master.IsPresented = false;//para cerrar el menu lateral
            switch (pageName)
            {
                case "AlarmsPage":
                    await Navigate(new AlarmsPage());
                    break;

                case "ClientsPage":
                    await Navigate(new ClientsPage());
                    break;

                case "SettingsPage":
                    await Navigate(new SettingsPage());
                    break;

                case "NewOrderPage":
                    await Navigate(new NewOrderPage());
                    break;

                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;

                default:
                    break;
            }
        }

        //metodo para eliminar el icono back al navegar a una pagina
        private static async Task Navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Back");//para IOs

            await App.Navigator.PushAsync(page);
        }


        //Metodo para user la instancia actual de la aplicacion para cambiar
        internal  void SetMainPage(string page)
        {
            switch (page)
            {
                case "MasterPage":
                    App.Current.MainPage = new MasterPage();
                    break;

            }
        }


    }
}
