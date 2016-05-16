using System;
using Newtonsoft.Json;

namespace MyOrders.Models
{
   public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryInformation { get; set; }
        public string Client { get; set; }
        public bool? IsDelivered { get; set; }
        public string Phone { get; set; }
    }
}
