using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinXAML
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var photoList = new List<string>
            {
                "Background.png",
                "Background.png",
                "Background.png"
            };
            
            MainCarousel.ItemsSource = photoList;
        }
    }
}
