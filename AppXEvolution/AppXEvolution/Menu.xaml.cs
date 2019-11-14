using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXEvolution
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            ButtonClientes.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MainPage());
            };

        }

        /*
        private void Button_ClickedClases(object sender, EventArgs e)
        {
            //GetMenu = new NavigationPage(new MainPage());
        }
        */


    }
}