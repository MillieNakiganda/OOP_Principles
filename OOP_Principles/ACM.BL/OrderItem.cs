using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem(int orderItemId)
        {
            //since productId has a private setter, we need to create it through the constructor
            OrderItemId = orderItemId;
        }

        public OrderItem()
        {
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public OrderItem Retrieve(int orderitemId)
        {
            //retrieve defined product
            return new OrderItem();
        }
        public bool Save()
        {
            //saves orerItems
            return true;
        }
        public bool validate()
        {
            //validates customer data
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}
