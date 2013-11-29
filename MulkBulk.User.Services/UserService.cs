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
        public System.Collections.IEnumerable All()
        {

            return _context.Users.All();
        }

        public UserEntity GetBy(string username)
        {
            return _context.Users.GetBy(username);
        }


        public UserEntity Create(string username, string password, string email, DateTime? created = null)
        {
            
            var user = new UserEntity()
            {
                UserName = username,
                Password = Crypto.HashPassword(password),
                Email = email,
                RegistrationDate = created ?? DateTime.Now
            };

        
            _users.Create(user);
            _context.SaveChanges();

            return user;
        }
   

        public UserMessages ComposeMessage(string mess, string to)
        {
            var message = new UserMessages()
            {
                Date = DateTime.Now,
                MessageContent = mess,
                SenderID = 1,
            };
            var use = _users.GetBy(message.SenderID);
            _messages.AddFor(message, use);

            _context.SaveChanges();

            return message;

        }
    }
}
 
