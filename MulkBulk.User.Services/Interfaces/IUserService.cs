using MulkBulk.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulkBulk.User.Services.Interfaces
{
    public  interface IUserService
    {
        IEnumerable All();

        UserMessages ComposeMessage(string messageContent, string authorId, MulkUser user);

        MulkUserProfiles Create(string email, 
            string firstname = "", string lastname = "", DateTime? birthday = null);

        bool DoesUserExist(string email);

    }
}
