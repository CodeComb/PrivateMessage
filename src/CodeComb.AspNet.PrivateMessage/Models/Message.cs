using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeComb.AspNet.PrivateMessage.Models
{
    [Table("AspNetPrivateMessages")]
    public class Message<TUser, TKey>
    {
        public TKey Id { get; set; }

        [MaxLength(256)]
        public string Title { get; set; }

        public string Content { get; set; }

        [ForeignKey("Sender")]
        public TKey? SenderId { get; set; }

        public virtual TUser Sender { get; set; }

        [ForeignKey("Receiver")]
        public TKey? ReceiverId { get; set; }

        public virtual TUser Receiver { get; set; }

        public DateTime Time { get; set; }
    }
}
