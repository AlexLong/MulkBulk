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
        UserMessages ComposeMessage(string mess, string to);

        MulkUser Create(string email, DateTime? created = null);

        bool DoesUserExist(string email);

    }
}
