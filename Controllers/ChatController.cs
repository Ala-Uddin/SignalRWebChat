using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRWebChat.Controllers
{
    public class ChatController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}