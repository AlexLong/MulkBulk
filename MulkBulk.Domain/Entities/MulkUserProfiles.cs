using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Entities
{
    public class MulkUserProfiles
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        private IList<UserMessages> _messages;
        public virtual IList<UserMessages> Messages
        {
            get { return _messages ?? (_messages = new List<UserMessages>()); }
            set { _messages = value; }
        }
        /**/
        public DateTime RegistrationDate { get; set; }




    }
}