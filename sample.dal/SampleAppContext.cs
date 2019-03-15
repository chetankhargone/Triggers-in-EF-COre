using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using sample.dal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sample.dal
{
    public class SampleAppContext : DbContext
    {
        
        private const string _dbConnection = @"Data Source=LEN-E560-051\CGLOCALHOST;Initial Catalog=customer.ef;Persist Security Info=True;User ID=sa;Password=Database@123";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(_dbConnection);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //public override Task<Int32> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return this.SaveChangesWithTriggersAsync(base.SaveChangesAsync, acceptAllChangesOnSuccess: true, cancellationToken: cancellationToken);
        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
