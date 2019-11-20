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

            SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);
            /*
            ButtonClientes.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MainPage());
            };*/

            ButtonClases.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Clases());
            };

            ButtonRutinas.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Rutinas());
            };

            GymEvolution2.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Clases());
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