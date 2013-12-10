using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.DTO;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI.WebControls;

namespace MulkBulk.Domain.Concrete
{

    public class MulkUserRepository : EfRepository<MulkUser>, IMulkUserRepository
    {
        public MulkUserRepository(DbContext context, bool SharedContext = false) : base(context, SharedContext) { }

        //   MulkUser GetUserId(string userId);

        public string GetUserName(string userName)
        {
            var query = ContextDbSet.Where(x => x.UserName == userName).Select(x => x.UserName).SingleOrDefault();
            return query;
        }

        public UserProfileDTO GetProfile(string username)
       {
           var data = ContextDbSet.Where(recordset => recordset.UserName == username)
                                  .Select(item => new UserProfileDTO
                                  {
                                       UserName = item.UserName,
                                       FirstName = item.MulkUserProfile.FirstName,
                                       LastName = item.MulkUserProfile.LastName,
                                      Email = item.MulkUserProfile.Email
                                  });

           return data.SingleOrDefault();
                                                         

       }
    }
     


}