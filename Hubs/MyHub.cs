using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRWebChat.Models;

namespace SignalRWebChat.Hubs
{
    public class MyHub : Hub
    {
        private ChatContext db = new ChatContext();
        public void GetAllMessage()
        {
            List<Chat> chat = db.Chats.ToList();
            Clients.Caller.GetAll(chat);
        }
        public void SendMessage(string user, string message)
        {
            Chat chat = new Chat()
            {
                Sender = user,
                Content = message
            };

            db.Chats.Add(chat);
            db.SaveChanges();

            Clients.All.Get(chat);
        }
    }
}