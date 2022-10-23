using System;
using Xamarin.Forms;

namespace TP01.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        void Confirmar(object sender, EventArgs e)
        {
            if (textId.Text == "admin" && textPass.Text == "senha@dmin")
            {
                DisplayAlert("Login realizado", "Id e senha corretos", "OK");

            }
            else
            {
                DisplayAlert("Login não realizado", "Id ou senha incorretos", "OK");
            }
        }

        void Limpar(object sender, EventArgs e)
        {
            textId.Text = "";
            textPass.Text = "";
        }

        void Creditos(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Feito por Gabriel Paulino - CB3010635", "OK");
        }
    }
}