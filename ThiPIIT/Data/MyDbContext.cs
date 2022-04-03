using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ThiPIIT.Models;

namespace ThiPIIT.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("ConnectionString") { }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Coin> Coins { get; set; }
    }
}