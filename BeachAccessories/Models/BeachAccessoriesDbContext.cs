using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeachAccessories.Models
{
    public class BeachAccessoriesDbContext : DbContext
    {
        public BeachAccessoriesDbContext() { }

        public DbSet<Hat> Hats { get; set; }
        public DbSet<Mat> Mats { get; set; }
        public DbSet<Mattress> Mattresses { get; set; }
        public DbSet<Ring> Rings { get; set; }
        public DbSet<Towel> Towels { get; set; }
        public DbSet<Umbrella> Umbrellas { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

    }
}