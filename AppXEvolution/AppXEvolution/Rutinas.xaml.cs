using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXEvolution
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Rutinas : ContentPage
	{
        private readonly HttpClient _client = new HttpClient();
        private const string Url = "https://gymevolution.azurewebsites.net/api/Rutinas";
        private ObservableCollection<Rutina> clases;

        public Rutinas ()
		{
			InitializeComponent ();
		}

        async override protected void OnAppearing()
        {

            string response = await _client.GetStringAsync(Url);
            List<Rutina> list = JsonConvert.DeserializeObject<List<Rutina>>(response);
            clases = new ObservableCollection<Rutina>(list);
            ItemListRutinas.ItemsSource = clases;
            base.OnAppearing();

        }
    }
}