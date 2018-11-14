using System.Collections.Generic;
using Xamarin.Forms;
using XamarinXAML.ViewModels;

namespace XamarinXAML
{
    public partial class MainPage : ContentPage
    {
        ChatViewModel vm;

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

            BindingContext = vm = new ChatViewModel();

            vm.Messages.CollectionChanged += (sender, e) =>
            {
                var target = vm.Messages[vm.Messages.Count - 1];
                MessagesListView.ScrollTo(target, ScrollToPosition.End, true);
            };
        }

        void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }

        void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }
    }
}
