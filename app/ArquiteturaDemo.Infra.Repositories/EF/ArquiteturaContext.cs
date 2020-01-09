using ArquiteturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ArquiteturaContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) // 28:55
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }

    }
}
