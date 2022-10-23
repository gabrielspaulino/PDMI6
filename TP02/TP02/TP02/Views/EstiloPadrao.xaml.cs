﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstiloPadrao : ContentPage
    {
        public EstiloPadrao()
        {
            InitializeComponent();
        }

        private async void BtnStyleClicked(object sender, EventArgs e)
        {
            Estilo.BackgroundColor = Color.Red;
        }
    }
}