using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TP01.Models;
using Xamarin.Forms;

namespace TP01.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string id;
        private string pass;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(id)
                && !String.IsNullOrWhiteSpace(pass);
        }

        public string Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public string Pass
        {
            get => pass;
            set => SetProperty(ref pass, value);
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
            Item newItem = new Item()
            {
                Id = Id,
                Pass = pass,
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
