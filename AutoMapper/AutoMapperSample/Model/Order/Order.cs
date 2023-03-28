using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperSample.Model.Order
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
