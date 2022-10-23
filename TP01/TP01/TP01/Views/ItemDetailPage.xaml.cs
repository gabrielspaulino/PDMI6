using System.ComponentModel;
using TP01.ViewModels;
using Xamarin.Forms;

namespace TP01.Views
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