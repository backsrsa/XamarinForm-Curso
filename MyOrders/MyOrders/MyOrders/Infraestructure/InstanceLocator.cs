using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOrders.ViewModels;

namespace MyOrders.Infraestructure
{
    public class InstanceLocator
    {
        public InstanceLocator()
        {
            Main= new MainViewModel();
        }
        public MainViewModel Main { get; set; }
    }
}
