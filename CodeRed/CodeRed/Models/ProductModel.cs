using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CodeRed.Models
{
    public class ProductModel : BaseModel
    {
        public ProductModel(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { SetProperty(ref quantity, value); }
        }
    }
}
