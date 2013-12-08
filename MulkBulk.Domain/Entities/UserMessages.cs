using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Entities
{
    public class UserMessages
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public string ReceiverID { get; set; }
        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual MulkUser Author { get; set; }
        public DateTime Date { get; set; }

    }
}