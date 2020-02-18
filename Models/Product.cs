using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Api
{
    public class Product
    {
        
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get;  set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

    }
}