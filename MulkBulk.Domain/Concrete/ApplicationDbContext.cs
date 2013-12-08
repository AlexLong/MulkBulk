using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class ApplicationDbContext : IdentityDbContext<MulkUser>
    {
        public ApplicationDbContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            //   modelBuilder.Entity<IdentityModels>().Map(x => x.ToTable("Identify Model"));

            base.OnModelCreating(modelBuilder);

        }
    }
}