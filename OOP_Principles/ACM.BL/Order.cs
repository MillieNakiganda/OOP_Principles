using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order(int orderId)
        {
            //since productId has a private setter, we need to create it through the constructor
            OrderId = orderId;
            orderItems = new List<OrderItem>();
        }

        //construtor chain to automatically call the other constructor
        public Order():this(0)
        {
            //since we have added the constructor above, best we set this one for other properties
        }
        public int OrderId { get; set; }      
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        //tracks date, time and timezone offset
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public bool validate()
        {
            //validates order
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
