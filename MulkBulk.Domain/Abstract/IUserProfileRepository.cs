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

        MulkUserProfiles GetBy(int userId );/*, bool includeProfile = false, bool includeRibbits = false,
                                               bool includeFollowers = false, bool includeFollowing = false*/

         MulkUserProfiles GetBy(string email);


        /*
        MulkUser GetBy(string username, bool includeProfile = false, bool includeRibbits = false,
            bool includeFollowers = false, bool includeFollowing = false);
         */


    }
}
