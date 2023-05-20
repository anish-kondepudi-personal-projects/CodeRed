using Xamarin.Forms;

namespace CodeRed.ViewModels
{
    public class SignUpPageViewModel : BaseViewModel
    {
        public Command SignUpCommand { get; }

        public SignUpPageViewModel()
        {
            SignUpCommand = new Command(OnSignUpClicked);
        }

        private void OnSignUpClicked()
        {
            // Logic for sign up button click
        }
    }
}
