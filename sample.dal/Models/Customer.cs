using System;
using System.Collections.Generic;
using System.Text;

namespace sample.dal.Models
{
    public class Customer : Trackable
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
