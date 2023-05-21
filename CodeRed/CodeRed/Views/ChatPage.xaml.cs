using System;
using System.Collections.Generic;
using CodeRed.ViewModels;

using Xamarin.Forms;

namespace CodeRed.Views
{	
	public partial class ChatPage : ContentPage
	{	
		public ChatPage(ChatPageViewModel chatPageViewModel)
		{
			InitializeComponent ();
			BindingContext = chatPageViewModel;
        }
	}
}

