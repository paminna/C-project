using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebNurgalieva.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string FIO { get; set; }
        public int DogId { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}