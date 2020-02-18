﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Api
{
    public class Address
    {
        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
