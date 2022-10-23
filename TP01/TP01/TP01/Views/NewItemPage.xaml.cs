using System;
using System.Collections.Generic;
using System.ComponentModel;
using TP01.Models;
using TP01.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01.Views
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