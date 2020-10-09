using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HungryFoodCorner.Models
{

    public class DbLayer : DbContext
    {
        public DbLayer(DbContextOptions<DbLayer> options) : base(options)
        {
                
        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
