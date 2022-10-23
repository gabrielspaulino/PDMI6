using System.ComponentModel;
using TP02.ViewModels;
using Xamarin.Forms;

namespace TP02.Views
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