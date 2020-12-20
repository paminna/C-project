using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebNurgalieva.Models
{
    public class DogContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Purchase> Purchases{get;set;}
    }
}