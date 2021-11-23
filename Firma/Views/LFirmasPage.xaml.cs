using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firma.Models;

namespace Firma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LFirmasPage : ContentPage
    {


        public LFirmasPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var listadireccione = await App.BaseDatos.ObtenerListaFirmas();
            lsfirmas.ItemsSource = listadireccione;
        }

        private async void toolbar01_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SignaturePage());

        }

        private async void lsfirmas_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            Models.ModelFirmas item = (Models.ModelFirmas)e.Item;
            var page = new Views.Page1();
            page.BindingContext = item;
            await Navigation.PushAsync(page);
        }
    }
}