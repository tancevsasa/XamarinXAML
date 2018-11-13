using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
            Messages.Add(new Message() { Text = "I like Blue. Shall we be ShoeMates?" });
            Messages.Add(new Message() { Text = "Good Idea :) My number is +454211451", User = App.User });

            OnSendCommand = new Command(() =>
            {
                if(!string.IsNullOrEmpty(TextToSend)){
                    Messages.Add(new Message() { Text = TextToSend, User = App.User });
                    TextToSend = string.Empty;
                }
               
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
