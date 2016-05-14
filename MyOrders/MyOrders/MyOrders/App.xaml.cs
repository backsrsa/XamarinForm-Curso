using MyOrders.Pages;
using Xamarin.Forms;

namespace MyOrders
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // The root page of your application
            MainPage = new MasterPage();
        }

        public static NavigationPage Navigator { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
