using MulkBulk.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulkBulk.Domain.Entities
{
    interface IProfileRepository : IRepository<MulkProfile>
    {

        MulkProfile GetBy(string email);




    }
}
