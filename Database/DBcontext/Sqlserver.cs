using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DBcontext
{
    public class Sqlserver : DbContext
    {
        public Sqlserver(DbContextOptions<Sqlserver> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c=>c.CustID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
