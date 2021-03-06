﻿using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class MessageRepository : EfRepository<UserMessages>, IMessageRepository
    {

        public MessageRepository(DbContext context, bool SharedContext = false) : base(context, SharedContext) { }

        public UserMessages GetBy(int id)
        {
            return Find(m => m.Id == id);
        }

        public IEnumerable<UserMessages> GetFor(MulkUser user)
        {
            return FindAll(m => m.ReceiverID == user.Id);
        }

        private IEnumerable<UserMessages> FindAll(Func<UserMessages, bool> func)
        {
            throw new NotImplementedException();
        }

        public void AddFor(UserMessages message, MulkUser user)
        {
            user.Messages.Add(message);

           if(!ShareContext)
           {
               Context.SaveChanges();
           }
        }
    }
}