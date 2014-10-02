using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1Store.Models
{
    public class Orders
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string CustomerId { get; set; }
        public DateTime Date { get; set; }
    }
}