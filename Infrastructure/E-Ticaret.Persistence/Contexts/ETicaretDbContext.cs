using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities;
using E_Ticaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
//using E_Ticaret.Domain.Entities;
namespace E_Ticaret.Persistence.Contexts
{
    public class ETicaretDbContext : DbContext
    {
          public ETicaretDbContext(DbContextOptions options) : base(options)
          {}

          public DbSet<Product> Products { get; set; }
          public DbSet<Order> Orders { get; set; }
          public DbSet<Customer> Customers { get; set; }
          public DbSet<Category> Categories { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                 _ = data.State switch
                 {
                       EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                       EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                       _=> DateTime.UtcNow
                 };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}