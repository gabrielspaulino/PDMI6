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
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://referential.p.rapidapi.com/v1/country?fields=currency%2Ccurrency_num_code%2Ccurrency_code%2Ccontinent_code%2Ccurrency%2Ciso_a3%2Cdial_code&limit=250"),
                Headers =
                {
                    { "X-RapidAPI-Key", "eb0c87391dmsh79b1c68adb56e5bp12ceb0jsn180862282ac1" },
                    { "X-RapidAPI-Host", "referential.p.rapidapi.com" },
                },
            };
            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var country = JsonConvert.DeserializeObject<List<Country>>(body);
            ListCountry.ItemsSource = country;
        }
    }
}
