using EntityFramworkPracticeCodeFirstAproch1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkPracticeCodeFirstAproch1.Data
{
    public class DemoContext:DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DemoCodeFirst;integrated security=SSPI;TrustServerCertificate=True;");
        }
    }
}
