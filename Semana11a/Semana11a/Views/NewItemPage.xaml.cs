using System;
using System.Collections.Generic;
using System.ComponentModel;
using Semana11a.Models;
using Semana11a.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana11a.Views
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