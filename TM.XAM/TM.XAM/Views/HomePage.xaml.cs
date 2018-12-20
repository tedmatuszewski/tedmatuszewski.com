using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TM.XAM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TM.XAM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        HomeViewModel viewModel;

        public HomePage ()
		{
			InitializeComponent();
            
            BindingContext = viewModel = new HomeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.IsEmpty())
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }
    }
}