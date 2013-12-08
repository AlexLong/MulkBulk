using Microsoft.AspNet.Identity.EntityFramework;
using MulkBulk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulkBulk.Domain.Entities
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class MulkUser : IdentityUser
    {
      public int ProfileId { get; set; }
      [ForeignKey("ProfileId")]
      public virtual MulkUserProfiles MulkUserProfile { get; set; }

      private ICollection<UserMessages> _messages;
      public virtual ICollection<UserMessages> Messages
      {
          get { return _messages ?? (_messages = new Collection<UserMessages>()); }
          set { _messages = value; }
      }

      public DateTime RegistrationDate { get; set; }


    }

}