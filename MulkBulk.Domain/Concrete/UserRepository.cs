using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class UserRepository : EfRepository<MulkUser> ,IUserRepository 
    {
      
        public UserRepository(DbContext context,bool shareContext) : base(context,shareContext) { }
        public MulkUser GetBy(int userId)
        {
            return Find(userId);
        }
        private IQueryable<MulkUser> BuildUserQuery(bool includeProfile, bool includeRibbits, bool includeFollowers, bool includeFollowing)
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
        public MulkUser GetBy(int id, bool includeProfile = false, bool includeRibbits = false,
          bool includeFollowers = false, bool includeFollowing = false)
        {
            var query = BuildUserQuery(includeProfile, includeRibbits, includeFollowers, includeFollowing);

            return query.SingleOrDefault(u => u.Id == id);
        }
        /*

        public MulkUser GetBy(string username, bool includeProfile = false, bool includeRibbits = false,
            bool includeFollowers = false, bool includeFollowing = false)
        {

            var query = BuildUserQuery(includeProfile, includeRibbits, includeFollowers, includeFollowing);
            
            return query.SingleOrDefault(u => u.UserName == username);
        }
         */


        public MulkUser GetBy(string username)
        {
            throw new NotImplementedException();
        }
    }
}