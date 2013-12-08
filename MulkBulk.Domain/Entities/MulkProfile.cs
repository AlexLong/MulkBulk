using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Entities
{
    public class MulkProfile
    {
        [Key]
        public int Id { get; set; }

        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual MulkUser Owner { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

        private ICollection<MulkFriend> _friends;
        public virtual ICollection<MulkFriend> Friends
        {
            get { return _friends ?? (_friends = new Collection<MulkFriend>()); }
            set { _friends = value; }
        }

    }
}