using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    public class AppContext:DbContext
    {
        private const string connStr = @"Data Source=DESKTOP-UV9IG5D\SQLEXPRESS01;Initial Catalog=Finance;Integrated Security=True;Application Name=Finance";

        public DbSet<Account> Account { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connStr);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Account").Entity<Account>();
        }
    }
}
