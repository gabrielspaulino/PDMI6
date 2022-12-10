using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TPFinal.Models;
using Xamarin.Forms;

namespace TPFinal.ViewModels
{
    [QueryProperty(nameof(itemNcm), nameof(itemNcm))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string nome;
        private double peso;
        private string nomeProdutor;
        private string emailProdutor;
        private string itemNcm;
        public string Ncm { get; set; }

        public string Nome
        {
            get => nome;
            set => SetProperty(ref nome, value);
        }

        public double Peso
        {
            get => peso;
            set => SetProperty(ref peso, value);
        }

        public string NomeProdutor
        {
            get => nomeProdutor;
            set => SetProperty(ref nomeProdutor, value);
        }

        public string EmailProdutor
        {
            get => emailProdutor;
            set => SetProperty(ref emailProdutor, value);
        }

        public string ItemNcm
        {
            get
            {
                return itemNcm;
            }
            set
            {
                itemNcm = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string ncm)
        {
            try
            {
                var item = await DataStore.GetItemAsync(ncm);
                Nome = item.Nome;
                Peso = item.Peso;
                NomeProdutor = item.NomeProdutor;
                EmailProdutor = item.EmailProdutor;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
