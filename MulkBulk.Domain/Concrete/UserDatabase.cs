using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{

    public class UserDatabase : DbContext
    {
        public UserDatabase() : base("UsersContext") { }
        public IDbSet<MulkUser> Users { get; set; }
        public IDbSet<UserMessages> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<UserMessages>()
                .HasRequired(m => m.Author)
                .WithMany()
                .HasForeignKey(m => m.SenderID);
             */
                            
            modelBuilder.Entity<MulkUser>().HasMany(m => m.Messages);
            base.OnModelCreating(modelBuilder);
        }
    }
}