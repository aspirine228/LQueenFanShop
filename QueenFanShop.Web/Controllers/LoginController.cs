using QueenFanShop.BuisnessLogic.Interfaces;
using QueenFanShop.Models.Enteties.General;
using QueenFanShop.Models.Enteties.User;
using QueenFanShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QueenFanShop.BuisnessLogic;
using System.Web.UI.WebControls;

namespace QueenFanShop.Web.Controllers
{
    public class LoginController : Controller
    {
        public readonly ISession _session;
        public LoginController()
        {
            BuisnessLogic.BuisnessLogic bl = new BuisnessLogic.BuisnessLogic();
            _session = bl.GetSessionBL();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Index()
        {
        
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Auth(ULoginData data)
        { UDbTable user;
           /* if (ModelState.IsValid)
            {
                using (var db = new )
                {
                    user = db.Users.FirstOrDefault(u => u.Username == data.UserName);
                }
            }*/
            USessionData udata = new USessionData();
            udata.UserName = data.UserName;
            udata.UserPassword = data.UserPassword;
            udata.SessionDate = DateTime.Now;
           //var userLogin = _session.UserLogin(data);
            ResponsMSG res = _session.GetUserSession(udata);
            if (res.Status)
            {
                HttpCookie httpcookie = _session.GenCookie(data.UserName);
                HttpCookie cookie = httpcookie;
               ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}