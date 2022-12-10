using System;
using System.Collections.Generic;
using System.ComponentModel;
using TPFinal.Models;
using TPFinal.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPFinal.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}