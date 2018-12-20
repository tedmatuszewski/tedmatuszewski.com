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


            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("uwp=68397844-4139-41b3-a270-31886ff2a5fd;" +
                  "android=befc8fa0-a672-453e-a6e7-7a47afcaba87;" +
                  "ios=59ae354c-e242-4343-9fd4-d9b2adb5fe7c;",
                  typeof(Analytics));
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
