using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Abstract
{
    public interface IContext : IDisposable
    {

        IUserRepository Users {get; }

        IMessageRepository Messages { get; }

        int SaveChanges();

    }
}