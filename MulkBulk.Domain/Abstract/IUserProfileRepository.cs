using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulkBulk.Domain.Abstract
{
    public interface IUserProfileRepository: IRepository<MulkUserProfiles>
    {

       // IQueryable<UserEntity> All();

        MulkUserProfiles GetEmail(string email);/*, bool includeProfile = false, bool includeRibbits = false,
                                               bool includeFollowers = false, bool includeFollowing = false*/
     



        /*
        MulkUser GetBy(string username, bool includeProfile = false, bool includeRibbits = false,
            bool includeFollowers = false, bool includeFollowing = false);
         */


    }
}
