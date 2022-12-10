using System.ComponentModel;
using TPFinal.ViewModels;
using Xamarin.Forms;

namespace TPFinal.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}