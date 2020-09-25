using System;
using System.Collections.ObjectModel;
using SneakersUIApp.Models;
using Xamarin.Essentials;

namespace SneakersUIApp.ViewModels
{
    public class SneakersViewModel
    {
        public ObservableCollection<Sneakers> sneakers { get; set; }
        public ObservableCollection<SneakerColor> sneakerColor { get; set; }

        public SneakersViewModel()
        {
            sneakers = new ObservableCollection<Sneakers>
            {
                new Sneakers { Name="NMD_R1 candy", Price="162",Picture="Sneakers1" },
                new Sneakers { Name="NMD_R1 pink white", Price="142",Picture="Sneakers2" },
                new Sneakers { Name="NMD_R1 mint pink", Price="179",Picture="Sneakers3" },
                new Sneakers { Name="NMD_R1 white mint", Price="154",Picture="Sneakers4" }
            };

            sneakerColor = new ObservableCollection<SneakerColor>
            {
                //new SneakerColor { ColorOption = "#819e94" },
                //new SneakerColor { ColorOption = "#dde5ed" },
                //new SneakerColor { ColorOption = "#d6c2bf" }
          
                new SneakerColor { ColorOption = ColorConverters.FromHex("#819e94") },
                new SneakerColor { ColorOption = ColorConverters.FromHex("#dde5ed") },
                new SneakerColor { ColorOption = ColorConverters.FromHex("#d6c2bf") }
            };
        }
    }
}
