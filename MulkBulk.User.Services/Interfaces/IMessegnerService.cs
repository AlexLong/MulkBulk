using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulkBulk.User.Services.Interfaces
{
    interface IMessegnerService 
    {

        UserMessages ComposeMessage(string mess, string touser, string from);





    }
}
