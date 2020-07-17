using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Assignment2.Entities
{
    public class CustomerContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RTH\TEW_SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");
        }
    }
}
