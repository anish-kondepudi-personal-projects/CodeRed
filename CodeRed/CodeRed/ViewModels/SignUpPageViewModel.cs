using System.Diagnostics;
using Xamarin.Forms;

namespace CodeRed.ViewModels
{
    public class SignUpPageViewModel : BaseViewModel
    {
        public Command SignUpCommand { get; }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        private string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public SignUpPageViewModel()
        {
            SignUpCommand = new Command(OnSignUpClicked);
        }

        private void OnSignUpClicked()
        {
            Debug.WriteLine("Name: " + Name);
            Debug.WriteLine("Email: " + Email);
            Debug.WriteLine("Password: " + Password);

            // Logic for sign up button click
            App.Current.MainPage = new NavigationPage(new Views.HomePage());
        }
    }
}
