using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace Joes_Pizza_Shop.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<PizzaItem> PizzaItems { get; set; }
        public virtual DbSet<CustomerOrderTable> CustomerOrderTables { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerOrderTable>().ToTable("CustomerOrderTable");
            builder.Entity<Order>().ToTable("Order");


        }
    }

}

