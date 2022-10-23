using System;
using System.Collections.Generic;
using System.ComponentModel;
using TP02.Models;
using TP02.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.Views
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