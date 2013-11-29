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
        MulkUser GetBy(string username);
        MulkUser Create(string username, string password, string email, DateTime? created = null);
        UserMessages ComposeMessage(string mess, string to);
    }
}
