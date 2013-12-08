using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Entities
{
    public class MulkUserProfiles
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress,MaxLength(128)]
        public string Email { get; set; }

        [MaxLength(128)]
        public string FirstName { get; set; }

         [MaxLength(128)]
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
    

    }
}