﻿using System;

namespace MyOrders.Models
{
   public class Order
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryInformation { get; set; }
        public string Client { get; set; }
        public bool IsDelivered { get; set; }
        public string Phone { get; set; }
    }
}
