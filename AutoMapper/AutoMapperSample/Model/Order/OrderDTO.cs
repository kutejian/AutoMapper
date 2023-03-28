using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperSample.Model.Order
{
    public class OrderDto
    {
        public string OrderNumber { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
    }
}
