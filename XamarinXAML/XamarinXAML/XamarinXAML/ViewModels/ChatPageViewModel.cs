using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinXAML.Models;

namespace XamarinXAML.ViewModels
{
    public class ChatPageViewModel
    {
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }

        public ChatPageViewModel()
        {
            Messages.Add(new Message() { Text = "Hi" });
            Messages.Add(new Message() { Text = "How are you?"});

            OnSendCommand = new Command(() =>
            {
                if(!string.IsNullOrEmpty(TextToSend)){
                    Messages.Add(new Message() { Text = TextToSend, User = App.User });
                    TextToSend = string.Empty;
                }
               
            });
        }
    }
}
