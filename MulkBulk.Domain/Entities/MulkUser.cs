using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Entities
{
    public class MulkUser
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        private IList<UserMessages> _messages;

        public virtual IList<UserMessages> Messages
        {
            get { return _messages ?? (_messages = new List<UserMessages>()); }
            set { _messages = value; }
        }

        public DateTime RegistrationDate { get; set; }




    }
}