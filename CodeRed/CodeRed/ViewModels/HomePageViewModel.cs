using System;
using System.Windows.Input;
using Xamarin.Forms;
using CodeRed.Views;

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
            App.Current.MainPage.Navigation.PushAsync(new Views.RequestPage());
        }

        private async void SupplyButtonClicked()
        {
            // Handle the logic for the "Supply" button click here
            // For example, you can navigate to another page or perform some action

            await Application.Current.MainPage.Navigation.PushAsync(new SupplyPage());
        }


    }
}

