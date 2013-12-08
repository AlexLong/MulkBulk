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
        private readonly IUserProfileRepository _userProfile;
        private readonly IMessageRepository _messages;
    

        public UserService(IContext context)
        {
            _context = context;
            _userProfile = context.UserProfile;
            _messages = context.Messages;
           }
        public IEnumerable All()
        {

            return _context.UserProfile.All();
        }
        public UserMessages ComposeMessage(string messageContent, string authorId, MulkUser user)
        {
       
            var message = new UserMessages()
            {
                Date = DateTime.Now,
                MessageContent = messageContent,
                AuthorId = authorId,
                ReceiverID = user.Id
            };
       
            _messages.AddFor(message,user);


            _context.SaveChanges();

            return message;

        }

        public bool DoesUserExist(string email)
        {
            return _userProfile.GetEmail(email) != null;
        }
        public MulkUserProfiles Create(string email, 
            string firstname = "", string lastname = "", DateTime? birthday = null)
        {
            var user = new MulkUserProfiles()
            {
                 Email = email,
                 FirstName = firstname,
                 LastName = lastname,
                 BirthDay = birthday
            };
            /*
            _userProfile.Create(user);

            _context.SaveChanges();
             */

            return user;
        }


    }
}
 
