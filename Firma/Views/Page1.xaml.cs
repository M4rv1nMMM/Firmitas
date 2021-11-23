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
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            InitializeComponent();
        }

        private void btnshow_Clicked(object sender, EventArgs e)
        {

            var image = new Models.ModelFirmas
            {
            
            };

                if (image != null)
                {

                    byte[] b = image.sign;
                    Stream ms = new MemoryStream(b);
                    imagen.Source = ImageSource.FromStream(() => ms);
                }

            
        }
    }
}