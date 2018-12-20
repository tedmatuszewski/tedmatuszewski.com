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
	public partial class ResumePage : ContentPage
	{
        ResumeViewModel viewModel;

        public ResumePage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new ResumeViewModel();
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