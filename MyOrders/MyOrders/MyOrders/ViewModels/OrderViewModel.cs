using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MyOrders.Models;
using MyOrders.Services;

namespace MyOrders.ViewModels
{
    public class OrderViewModel
    {
        readonly ApiService _apiService;
        readonly DialogService _dialogService;
        public OrderViewModel()
        {
            _apiService = new ApiService();
            _dialogService = new DialogService();
            DeliveryDate = DateTime.Today;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryInformation { get; set; }
        public string Client { get; set; }
        public bool? IsDelivered { get; set; }
        public string Phone { get; set; }

        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(Save);
            }
        }

        private async void Save()
        {
            try
            {
                await _apiService.CreateOrder(new Order()
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = Title,
                    Client = Client,
                    DeliveryDate = DeliveryDate,
                    DeliveryInformation = DeliveryInformation,
                    Description = Description,
                    IsDelivered = false
                });
                await _dialogService.ShowMessage("Information", "The order has been created");
            }
            catch
            {
                await _dialogService.ShowMessage("Information", "Has been an error unexpected");
            }
        }



    }
}
