﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6Ex1
{
    [Serializable]
    class Customer
    {
        public int CustId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Customer() { }
    }
}
