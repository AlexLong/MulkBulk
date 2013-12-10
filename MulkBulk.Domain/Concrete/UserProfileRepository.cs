using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class UserProfileRepository : EfRepository<MulkUserProfiles> ,IUserProfileRepository 
    {
      
        public UserProfileRepository(DbContext context,bool shareContext) : base(context,shareContext) { }
        public MulkUserProfiles GetBy(int userId)
        {
            return Find(userId);
        }
        private IQueryable<MulkUserProfiles> BuildUserQuery()/*bool includeProfile, bool includeRibbits, bool includeFollowers, bool includeFollowing*/
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
     
        public string GetEmail(string email)
        {
           return ContextDbSet.Where(x => x.Email == email).Select(x => x.Email).SingleOrDefault();
        }

    }
}