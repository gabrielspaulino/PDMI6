using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeForm : ContentPage
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private async void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
            var contato = new Contato(Nome.Text, Convert.ToInt32(Idade.Text), Profissao.Text, Pais.Text);

            var detalhePage = new DetalheView();
            detalhePage.BindingContext = contato;
            await Navigation.PushAsync(detalhePage);
        }
    }
}