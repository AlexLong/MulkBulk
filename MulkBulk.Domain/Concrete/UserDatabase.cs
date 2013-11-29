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
        public IDbSet<UserEntity> Users { get; set; }
        public IDbSet<UserMessages> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasMany(m => m.Messages);
            base.OnModelCreating(modelBuilder);
        }
    }
}