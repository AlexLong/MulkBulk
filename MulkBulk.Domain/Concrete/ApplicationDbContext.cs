using Microsoft.AspNet.Identity.EntityFramework;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class ApplicationDbContext : IdentityDbContext<MulkUser>
    {
        public ApplicationDbContext() : base("UsersContext") { }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            //   modelBuilder.Entity<IdentityModels>().Map(x => x.ToTable("Identify Model"));

            base.OnModelCreating(modelBuilder);

        }
    }
}