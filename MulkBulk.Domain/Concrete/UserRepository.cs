using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class UserRepository : EfRepository<UserEntity> ,IUserRepository 
    {
      
        public UserRepository(DbContext context,bool shareContext) : base(context,shareContext) { }
        public UserEntity GetBy(int userId)
        {
            return Find(userId);
        }
        private IQueryable<UserEntity> BuildUserQuery(bool includeProfile, bool includeRibbits, bool includeFollowers, bool includeFollowing)
        {
            var query = ContextDbSet.AsQueryable();
            /*
            if (includeProfile)
                query = DbSet.Include(u => u.Profile);

            if (includeRibbits)
                query = DbSet.Include(u => u.Ribbits);

            if (includeFollowers)
                query = DbSet.Include(u => u.Followers);

            if (includeFollowing)
                query = DbSet.Include(u => u.Followings);
             * */
            return query;
        }
        public UserEntity GetBy(int id, bool includeProfile = false, bool includeRibbits = false,
          bool includeFollowers = false, bool includeFollowing = false)
        {
            var query = BuildUserQuery(includeProfile, includeRibbits, includeFollowers, includeFollowing);

            return query.SingleOrDefault(u => u.UserID == id);
        }

        public UserEntity GetBy(string username, bool includeProfile = false, bool includeRibbits = false,
            bool includeFollowers = false, bool includeFollowing = false)
        {

            var query = BuildUserQuery(includeProfile, includeRibbits, includeFollowers, includeFollowing);
            
            return query.SingleOrDefault(u => u.UserName == username);
        }


        public UserEntity GetBy(string username)
        {
            throw new NotImplementedException();
        }
    }
}