using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using MulkBulk.User.Services;
using MulkBulk.User.Services.Interfaces;
using System.Collections;

namespace MulkBulk.User.Services
{
    public class UserService : IUserService
    {
        protected IContext _context;
        private readonly IUserRepository _users;
        private readonly IMessageRepository _messages;

        public UserService(IContext context)
        {
            _context = context;
            _users = context.Users;
            _messages = context.Messages;
        }
        public IEnumerable All()
        {

            return _context.Users.All();
        }
        public UserMessages ComposeMessage(string mess, string to)
        {
            var message = new UserMessages()
            {
                Date = DateTime.Now,
                MessageContent = mess,
                AuthorId = 1,
            };
            var use = _users.GetBy(message.AuthorId);
            _messages.AddFor(message, use);

            _context.SaveChanges();

            return message;

        }

        public bool DoesUserExist(string email)
        {
            return _users.GetBy(email) != null;
        }
        public MulkUser Create(string email, DateTime? created = null)
        {
            var user = new MulkUser()
            {
                 Email = email,
                 RegistrationDate = DateTime.Now
            };
            _users.Create(user);
            _context.SaveChanges();
            return user;
        }


    }
}
 
