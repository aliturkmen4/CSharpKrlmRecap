using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.NORTHWNDModels
{
    public class CustomerOrder
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public int OrderCount { get; set; }
    }
   public  class CustomNRTHWNDContext:NORTHWNDContext
    {
        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public CustomNRTHWNDContext()
        {

        }
        public CustomNRTHWNDContext(DbContextOptions<NORTHWNDContext> options) :base(options) //aslında çalışan yine NRTHWNDContext olacak ama scaffolding gibi bir işlem yaparsam sorun yaşamamak adına bunu yapıyorum!!
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasNoKey();
            });
        }
    }
}
