using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinXAML.ViewModels;

namespace XamarinXAML.Views.Partials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatInputBarView : ContentView
    {
        public ChatInputBarView()
        {
            InitializeComponent();

            this.BindingContext = new ChatPageViewModel();

            if (Device.RuntimePlatform == Device.iOS)
            {
                this.SetBinding(HeightRequestProperty, new Binding("Height", BindingMode.OneWay, null, null, null, chatTextInput));
            }
        }
        public void Handle_Completed(object sender, EventArgs e)
        {
            if (BindingContext != null)
            {
                (this.Parent.Parent.BindingContext as ChatPageViewModel).OnSendCommand.Execute(null);
            }
            
            chatTextInput.Focus();
        }

        public void UnFocusEntry()
        {
            chatTextInput?.Unfocus();
        }

    }
}
