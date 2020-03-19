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
   /*    public ActionResult Login()
        {

            return View();
        }
        */
        public ActionResult Login(ULoginData data)
        {
            USessionData udata = new USessionData();
            udata.UserName = data.UserName;
            udata.UserPassword = data.UserPassword;
            udata.SessionDate = DateTime.Now;

            ResponsMSG status = _session.GetUserSession(udata);


            return View();
        }
    }
}