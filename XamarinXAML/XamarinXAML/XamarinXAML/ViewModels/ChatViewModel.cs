using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinXAML.Models;

namespace XamarinXAML.ViewModels
{
    public class ChatViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Message> Messages { get; }

        string outgoingText = string.Empty;

        public string OutGoingText
        {
            get { return outgoingText; }
            set { SetProperty(ref outgoingText, value); }
        }

        public ICommand SendCommand { get; set; }

        public ChatViewModel()
        {
            Messages = new ObservableRangeCollection<Message>();

            InitializeMock();

            SendCommand = new Command(() =>
            {
                var message = new Message
                {
                    Text = OutGoingText,
                    IsIncoming = false,
                    MessageDateTime = DateTime.Now
                };

                Messages.Add(message);
                OutGoingText = string.Empty;
            });
        }

        public void InitializeMock()
        {
            Messages.ReplaceRange(new List<Message>
            {
                new Message { Text = "I like Blue. Shall we be ShoeMates?", IsIncoming = false, MessageDateTime = DateTime.Now.AddMinutes(-25)},
                new Message { Text = "Good Idea :) My number is +45421451", IsIncoming = true, MessageDateTime = DateTime.Now.AddMinutes(-24)},
            });
        }
    }
}
