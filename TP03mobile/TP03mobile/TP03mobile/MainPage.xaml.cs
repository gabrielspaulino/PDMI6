using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP03mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Login();
        }

        public async void Login()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44318/api/Logins1");
            var login = JsonConvert.DeserializeObject<List<Login>>(response);
            ListLogin.ItemsSource = login;
        }
    }
}
