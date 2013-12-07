using Microsoft.AspNet.Identity.EntityFramework;
using MulkBulk.Domain.Entities;

namespace MulkBulk.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class IdentityModels : IdentityUser
    {
        public virtual MulkUser MulkUsers { get; set; }

    }
    public class ApplicationDbContext : IdentityDbContext<IdentityModels>
    {
        public ApplicationDbContext() : base("UsersContext"){}

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
         //   modelBuilder.Entity<IdentityModels>().Map(x => x.ToTable("Identify Model"));

            base.OnModelCreating(modelBuilder);

        }
    }
}