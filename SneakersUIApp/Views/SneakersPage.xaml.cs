using System;
using System.Collections.Generic;
using SneakersUIApp.ViewModels;
using Xamarin.Forms;

namespace SneakersUIApp.Views
{
    public partial class SneakersPage : ContentPage
    {
        public SneakersPage()
        {
            InitializeComponent();
            BindingContext = new SneakersViewModel();
        }
    }
}
