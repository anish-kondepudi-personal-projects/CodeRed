using System.Collections.ObjectModel;
using System.Windows.Input;
using CodeRed.Models;
using Xamarin.Forms;

namespace CodeRed.ViewModels
{
    public class RequestPageViewModel : BaseViewModel
    {
        private decimal totalPrice;
        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { SetProperty(ref totalPrice, value); }
        }

        public ObservableCollection<ProductViewModel> Products { get; set; }

        public ICommand RequestCommand { get; private set; }

        public RequestPageViewModel()
        {
            Products = new ObservableCollection<ProductViewModel>
            {
                new ProductViewModel(new ProductModel("Product 1", (decimal)1.5, 0), CalculateTotalPrice),
                new ProductViewModel(new ProductModel("Product 2", (decimal)2.0, 0), CalculateTotalPrice),
                new ProductViewModel(new ProductModel("Product 2", (decimal)2.5, 0), CalculateTotalPrice)
                // Add more products as needed
            };

            CalculateTotalPrice();

            RequestCommand = new Command(Request);
        }

        private void CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Product.Price * product.Product.Quantity;
            }

            TotalPrice = total;
        }

        private void Request()
        {
            // Handle the request logic here
        }
    }
}
