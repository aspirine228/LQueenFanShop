using QueenFanShop.BuisnessLogic.Interfaces;
using QueenFanShop.Models.Enteties.General;
using QueenFanShop.Models.Enteties.User;
using QueenFanShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        {
            USessionData udata = new USessionData();
            udata.UserName = data.UserName;
            udata.UserPassword = data.UserPassword;
            udata.SessionDate = DateTime.Now;
        //    var userLogin = _session.UserLogin(data);
            ResponsMSG res = _session.GetUserSession(udata);
            if (res.Status)
            {
                HttpCookie cookie = _session.GenCookie(data.UserName);
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