using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using TM.DTO.Objects;
using Xamarin.Forms;

namespace TM.XAM.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<ContentDto> Identity { get; set; }

        public ObservableCollection<ContentDto> Quotes { get; set; }

        string header = string.Empty;

        public string Header
        {
            get { return header; }
            set { SetProperty(ref header, value); }
        }

        string about = string.Empty;

        public string About
        {
            get { return about; }
            set { SetProperty(ref about, value); }
        }
        
        public Command LoadItemsCommand { get; set; }

        public HomeViewModel()
        {
            Title = "Home";
            Identity = new ObservableCollection<ContentDto>();
            Quotes = new ObservableCollection<ContentDto>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        public bool IsEmpty()
        {
            if(this.Identity == null || this.Identity.Count == 0)
            {
                return true;
            }

            return false;
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                using (var client = new WebClient())
                {
                    var uri = new Uri("https://tedmatuszewskiapi.azurewebsites.net/api/content/home");
                    var response = await client.DownloadStringTaskAsync(uri);
                    var json = JsonConvert.DeserializeObject<HomeDto>(response);

                    this.Header = json.IntroductionHeader;
                    this.About = json.IntroductionBody;

                    json.Identity.ForEach(i => this.Identity.Add(i));
                    json.Quotes.ForEach(q => this.Quotes.Add(q));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
