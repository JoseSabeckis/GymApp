using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXEvolution
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _client = new HttpClient();
        private const string Url = "https://gymevolution.azurewebsites.net/api/Clientes";
        private ObservableCollection<Cliente> cliente;

        public MainPage()
        {
            InitializeComponent();
        }

        async override protected void OnAppearing()
        {

            string response = await _client.GetStringAsync(Url);
            List<Cliente> list = JsonConvert.DeserializeObject<List<Cliente>>(response);
            cliente = new ObservableCollection<Cliente>(list);
            ItemListClientes.ItemsSource = cliente;
            base.OnAppearing();

        }


    }
}
