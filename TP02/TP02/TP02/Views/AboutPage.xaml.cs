using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void BtnPadrao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloPadrao());
        }

        private async void BtnDinamico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloDinamico());
        }
        private async void BtnEt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventTriggers());
        }

        private async void BtnSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewSimples());
        }

        private async void BtnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeForm());
        }
    }
}