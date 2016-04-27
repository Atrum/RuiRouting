using RuiRoutingTest.ViewModels;
using Xamarin.Forms;

namespace RuiRoutingTest
{
    public class App : Application
    {
        public App()
        {
            var viewModel = new AppBootstrapper();
            viewModel.Init();
            MainPage = viewModel.CreateMainPage();
        }

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
