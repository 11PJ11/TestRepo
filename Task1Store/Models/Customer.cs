using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task1Store.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Born { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
    public class CustomerDBContext:DbContext
    {
        DbSet<Customer> Customers;
    }
}