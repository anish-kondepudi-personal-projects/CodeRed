using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CodeRed.ViewModels
{
	public class ChatPageViewModel : BaseViewModel
	{
        private string newMessageText;

        public ObservableCollection<string> Messages { get; set; }

        public string NewMessageText
        {
            get => newMessageText;
            set
            {
                newMessageText = value;
                OnPropertyChanged();
            }
        }

        public ICommand SendMessageCommand { get; private set; }

        public ChatPageViewModel(string message)
        {
            Messages = new ObservableCollection<string>();
            Messages.Add(message);
            SendMessageCommand = new Command(SendMessage);
        }

        private void SendMessage()
        {
            if (string.IsNullOrWhiteSpace(NewMessageText))
                return;

            var newMessage = NewMessageText;

            Messages.Add(newMessage);
            NewMessageText = string.Empty;
        }
    }
}

