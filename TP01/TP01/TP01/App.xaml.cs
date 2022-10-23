using System;
using TP01.Services;
using TP01.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01
{
    public partial class App : Application
    {
        private string id;
        private string pass;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
