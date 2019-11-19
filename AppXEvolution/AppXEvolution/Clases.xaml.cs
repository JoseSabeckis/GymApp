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
	public partial class Clases : ContentPage
	{
        private readonly HttpClient _client = new HttpClient();
        private const string Url = "https://gymevolution.azurewebsites.net/api/Clases";
        private ObservableCollection<Clase> clases;

        public Clases ()
		{
			InitializeComponent ();
		}

        async override protected void OnAppearing()
        {
            
            string response = await _client.GetStringAsync(Url);
            List<Clase> list = JsonConvert.DeserializeObject<List<Clase>>(response);
            clases = new ObservableCollection<Clase>(list);
            ItemListClases.ItemsSource = clases;
            base.OnAppearing();
            
        }

    }
}