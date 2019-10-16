using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using MvxForms.Core.Models;
using MvxForms.Core.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvxForms.Core.Views
{
    public partial class MvxListPage : MvxContentPage<MvxListViewModel>
    {
		public MvxListPage ()
		{
			InitializeComponent ();
            

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetJsonData();
        }

        /// <summary>
        /// Metoda czytająca zawartość pliku JSON wstawiająca dane do Listy
        /// </summary>
        public void GetJsonData()
        {
           //być może potrzebny osobny sposób odczytu pliku
           /*if (Device.RuntimePlatform == Device.iOS)
            {
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
            }*/

            var jsonFileName = "peaks.json";
            var ObjPeaksList = new PeaksList();
            var assembly = typeof(MvxListPage).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                ObjPeaksList = JsonConvert.DeserializeObject<PeaksList>(jsonString);
            }

            listViewPeaks.ItemsSource = ObjPeaksList.Peaks;
        }
    }
}
