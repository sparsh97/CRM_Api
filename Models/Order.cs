using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Api
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int prodQuantity { get; set; }
    }
}
