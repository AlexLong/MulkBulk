using MulkBulk.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class Context : IContext
    {

        protected DbContext _db;

        public Context(DbContext context = null, 
            IUserProfileRepository users = null,
            IMessageRepository messages = null
            )
        {
            _db = context ?? new ApplicationDbContext();
            UserProfile = UserProfile ?? new UserProfileRepository(_db, true); 
            Messages = messages ?? new MessageRepository(_db, true);
            
        }

        public IUserProfileRepository UserProfile
        {
            get;
            private set;
        }
        public IMessageRepository Messages
        {
            get;
            private set;
        }

        
     
        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            if(_db != null)
            {
                try
                {
                    _db.Dispose();
                }
                catch { }
            }
        }


    }
}