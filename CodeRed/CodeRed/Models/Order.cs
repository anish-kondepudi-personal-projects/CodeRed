using System.Collections.Generic;
using System.ComponentModel;

namespace CodeRed.Models
{
    public class Order : INotifyPropertyChanged
    {
        private bool isVisible;

        public decimal Price { get; set; }
        public List<string> Products { get; set; }
        public double Distance { get; set; }
        public string UserName { get; set; }

        public string ProductsString => string.Join(", ", Products);

        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                if (isVisible != value)
                {
                    isVisible = value;
                    OnPropertyChanged(nameof(IsVisible));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
