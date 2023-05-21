using CodeRed.Views;
using Xamarin.Forms;

namespace CodeRed.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignUpCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            SignUpCommand = new Command(OnSignUpClicked);
        }

        private void OnLoginClicked()
        {
            // Logic for login button click
            App.Current.MainPage = new NavigationPage(new Views.HomePage());
        }

        private void OnSignUpClicked()
        {
            // Navigate to the SignUpPage
            App.Current.MainPage.Navigation.PushAsync(new Views.SignUpPage());
        }
    }
}
