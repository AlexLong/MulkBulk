using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulkBulk.Domain.Abstract
{
   public interface IMessageRepository : IRepository<UserMessages>
   {

       UserMessages  GetBy(int id);

       IEnumerable<UserMessages> GetFor(MulkUserProfiles user);
       void AddFor(UserMessages message, MulkUserProfiles user);

   }
}
