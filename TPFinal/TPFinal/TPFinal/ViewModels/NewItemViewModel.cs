using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TPFinal.Models;
using Xamarin.Forms;

namespace TPFinal.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string nome;
        private double peso;
        private string nomeProdutor;
        private string emailProdutor;
        private string ncm;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nome)
                && !Double.IsNaN(peso)
                && !String.IsNullOrWhiteSpace(nomeProdutor)
                && !String.IsNullOrWhiteSpace(emailProdutor)
                && !String.IsNullOrWhiteSpace(ncm);
        }

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

        public string Ncm
        {
            get => ncm;
            set => SetProperty(ref ncm, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Mercadoria newItem = new Mercadoria()
            {
                Nome = nome,
                Peso = peso,
                NomeProdutor = nomeProdutor,
                EmailProdutor = emailProdutor,
                Ncm = ncm
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
