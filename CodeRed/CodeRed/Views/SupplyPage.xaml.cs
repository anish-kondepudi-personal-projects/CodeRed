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
                        Price = 9.00m,
                        Products = new List<string> { "2 Tampons", "3 Pads" },
                        Distance = 2.5,
                        UserName = "Anna",
                        IsVisible = true
                    },
                    new Order
                    {
                        Price = 4.50m,
                        Products = new List<string> { "3 Pads"},
                        Distance = 4.2,
                        UserName = "Bella",
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
            var destinationPageViewModel = new ChatPageViewModel("You are now connected with the requester. You may now work together to agree on a location.");
            var destinationPage = new Views.ChatPage(destinationPageViewModel);
            App.Current.MainPage.Navigation.PushAsync(destinationPage);
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
