﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Apifood.Database
{
    public class Customer
    {
        [Key]
        public int customerid { get; set; }
        public string customername { get; set; }
        public string customerusername { get; set; }
        public string customerpassword { get; set; }
        public string customeremail { get; set; }
        public string customernumber { get; set; }

        public string customeraddress { get; set; }
    }
}
