using QueenFanShop.BuisnessLogic.Core;
using QueenFanShop.BuisnessLogic.Interfaces;
using QueenFanShop.Models.Enteties.General;
using QueenFanShop.Models.Enteties.User;
using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using QueenFanShop.BuisnessLogic;
using System.Web;
using System.Web.Mvc;

namespace QueenFanShop.BuisnessLogic.LogicBL

{


  public  class SessionBL:UserApi,ISession
    { 
        public HttpCookie GenCookie (string UserName)
        {
            throw new NotImplementedException();
        }
        public ResponsMSG GetUserSession(USessionData udata)
        {
            return UserSession(udata);
        }
    }
}
