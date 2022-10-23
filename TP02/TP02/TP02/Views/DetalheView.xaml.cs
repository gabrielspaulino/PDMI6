using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        public DetalheView()
        {
            InitializeComponent();
        }

        private async void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeForm());
        }
    }
}