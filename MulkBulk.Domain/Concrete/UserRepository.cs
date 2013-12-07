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
        private IQueryable<MulkUser> BuildUserQuery(/*bool includeProfile, bool includeRibbits, bool includeFollowers, bool includeFollowing*/)
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
     
        public MulkUser GetBy(string email)
        {

            var query = BuildUserQuery();


            return query.FirstOrDefault(x => x.Email == email);
        
        } 
        
       

    }
}