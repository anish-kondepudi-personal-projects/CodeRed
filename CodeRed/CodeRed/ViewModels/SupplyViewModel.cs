using System.Collections.Generic;
using System.ComponentModel;
using CodeRed.Models;

namespace CodeRed.ViewModels
{
    public class SupplyViewModel : INotifyPropertyChanged
    {
        private List<Order> _orders;

        public List<Order> Orders
        {
            get { return _orders; }
            set
            {
                if (_orders != value)
                {
                    _orders = value;
                    OnPropertyChanged(nameof(Orders));
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
