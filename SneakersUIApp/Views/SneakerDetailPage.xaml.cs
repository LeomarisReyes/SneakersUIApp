using System;
using System.Collections.Generic;
using SneakersUIApp.ViewModels;
using Xamarin.Forms;

namespace SneakersUIApp.Views
{
    public partial class SneakerDetailPage : ContentPage
    {
        public SneakerDetailPage()
        {
            InitializeComponent();
            BindingContext = new SneakersViewModel();

        }
    }
}
