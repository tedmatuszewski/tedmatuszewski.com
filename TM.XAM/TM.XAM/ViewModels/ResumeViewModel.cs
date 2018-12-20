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
    public class ResumeViewModel : BaseViewModel
    {
        public ObservableCollection<ContentDto> WorkHistory { get; set; }

        public ObservableCollection<ContentDto> EducationHistory { get; set; }

        public ObservableCollection<ContentDto> Skills { get; set; }

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

        public ResumeViewModel()
        {
            Title = "Home";
            WorkHistory = new ObservableCollection<ContentDto>();
            EducationHistory = new ObservableCollection<ContentDto>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        public bool IsEmpty()
        {
            if (this.WorkHistory == null || this.WorkHistory.Count == 0 || this.EducationHistory == null || this.EducationHistory.Count == 0)
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
                    var uri = new Uri("https://tedmatuszewskiapi.azurewebsites.net/api/content/about");
                    var response = await client.DownloadStringTaskAsync(uri);
                    var json = JsonConvert.DeserializeObject<AboutDto>(response);

                    json.Work.ForEach(i => this.WorkHistory.Add(i));
                    json.Education.ForEach(q => this.EducationHistory.Add(q));
                    json.Skills.ForEach(s => this.Skills.Add(s));
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
