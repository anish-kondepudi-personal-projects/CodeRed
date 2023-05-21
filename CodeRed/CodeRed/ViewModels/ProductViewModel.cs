using System.Collections.ObjectModel;
using System.Windows.Input;
using CodeRed.Models;
using Xamarin.Forms;
using System;

namespace CodeRed.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private ProductModel product;
        public ProductModel Product
        {
            get { return product; }
            set { SetProperty(ref product, value); }
        }

        public ICommand IncrementCommand { get; set; }
        public ICommand DecrementCommand { get; set; }

        private Action CalculateTotalPrice;

        public ProductViewModel(ProductModel product, Action calculateTotalPrice)
        {
            Product = product;
            CalculateTotalPrice = calculateTotalPrice;

            IncrementCommand = new Command(IncrementQuantity);
            DecrementCommand = new Command(DecrementQuantity);
        }

        private void IncrementQuantity()
        {
            Console.WriteLine("Incrementing!");
            Product.Quantity++;
            CalculateTotalPrice();
        }

        private void DecrementQuantity()
        {
            Console.WriteLine("Decrementing!");
            if (Product.Quantity > 0)
                Product.Quantity--;
            CalculateTotalPrice();
        }
    }
}
