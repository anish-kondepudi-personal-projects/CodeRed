﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace CodeRed.ViewModels
{
	public class HomePageViewModel : BaseViewModel
    {

        public ICommand RequestCommand { get; private set; }
        public ICommand SupplyCommand { get; private set; }

		public HomePageViewModel()
		{
            RequestCommand = new Command(RequestButtonClicked);
            SupplyCommand = new Command(SupplyButtonClicked);
        }

        private void RequestButtonClicked()
        {
            // Handle the logic for the "Request" button click here
            // For example, you can navigate to another page or perform some action
        }

        private void SupplyButtonClicked()
        {
            // Handle the logic for the "Supply" button click here
            // For example, you can navigate to another page or perform some action
        }
    }
}

