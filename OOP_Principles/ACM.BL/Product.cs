using ACM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase,ILoggable
    {
        public Product(int productId)
        {
            //since productId has a private setter, we need to create it through the constructor
            ProductId = productId;
        }

        public Product()
        {
            //since we have added the constructor above, best we set this one for other properties
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        private string _productname;
        public string ProductName { 
            get 
            {

                return StringHandler.InsertSpaces(_productname);
            } 
            set
            {
                _productname = value;
            } }
        
        public override bool validate()
        {
            //validates customer data
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        public string Log()
        {
            return $"{ProductId} {ProductName} Details: {ProductDescription} Status: {EntitySate.ToString()}";
        }
    }
}
