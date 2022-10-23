using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TP01.Models;
using Xamarin.Forms;

namespace TP01.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string pass;
        private string description;
        public string Id { get; set; }

        public string Pass
        {
            get => pass;
            set => SetProperty(ref pass, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Pass = item.Pass;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
