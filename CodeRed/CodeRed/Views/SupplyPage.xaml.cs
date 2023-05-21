using Xamarin.Forms;
using CodeRed.ViewModels;
using CodeRed.Models;
using System.Collections.Generic;
using System;

namespace CodeRed.Views
{
    public partial class SupplyPage : ContentPage
    {
        public SupplyPage()
        {
            InitializeComponent();
            BindingContext = new SupplyViewModel
            {
                Orders = new List<Order>
                {
                    new Order
                    {
                        Price = 10.99m,
                        Products = new List<string> { "Product 1", "Product 2", "Product 3" },
                        Distance = 2.5,
                        UserName = "John Doe",
                        IsVisible = true
                    },
                    new Order
                    {
                        Price = 15.49m,
                        Products = new List<string> { "Product 4", "Product 5" },
                        Distance = 4.2,
                        UserName = "Jane Smith",
                        IsVisible = true
                    }
                }
            };

            // Set IsVisible to true for each order
            var viewModel = BindingContext as SupplyViewModel;
            foreach (var order in viewModel.Orders)
            {
                order.IsVisible = true;
            }
        }

        private void AcceptButton_Clicked(object sender, System.EventArgs e)
        {
            // Handle accept button click
            var acceptedProduct = (sender as Button)?.BindingContext as Order;
            // Perform actions for accepting the product
        }

        private void RejectButton_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.BindingContext is Order order)
            {
                var viewModel = BindingContext as SupplyViewModel;
                order.IsVisible = false;
                viewModel.Orders.Remove(order);
            }
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
