using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalRWebChat.Models
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Sender { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; } = DateTime.Now;
    }
    public class ChatContext : DbContext
    {
        public DbSet<Chat> Chats { get; set; }
        public ChatContext() : base("ChatConnection")
        {

        }
    }
}