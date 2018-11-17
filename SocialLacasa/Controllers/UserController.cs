using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialLacasa.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult MassOrders()
        {
            return View();
        }
        public ActionResult AddFunds()
        {
            return View();
        }
        public ActionResult Subscriptions()
        {
            return View();
        }
        public ActionResult NewOrder()
        {
            return View();
        }
    }
}