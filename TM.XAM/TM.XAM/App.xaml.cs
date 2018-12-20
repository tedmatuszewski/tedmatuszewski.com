using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TM.XAM.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TM.XAM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            var conn = "uwp=f57c9cf0-2399-4256-99da-d10d99604f79;android=b4f324a0-a810-4572-9ebb-7fc3348a357b;ios=1acf2f58-f1f0-40ea-a426-b8bbc26d8ec6;";

            AppCenter.Start(conn, typeof(Analytics));
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
