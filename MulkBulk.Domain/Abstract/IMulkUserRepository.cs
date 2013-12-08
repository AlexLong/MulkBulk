using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulkBulk.Domain.Abstract
{
  public interface IMulkUserRepository : IRepository<MulkUser>
  {

      MulkUser GetUserId(string userId);
      MulkUser GetUserName(string userName);

  }
}
