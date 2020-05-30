using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using QueenFanShop.Models.Enteties.General;
using QueenFanShop.Models.Enteties.User;

namespace QueenFanShop.BuisnessLogic.Interfaces
{
    public interface ISession
    {
        ResponsMSG GetUserSession(USessionData udata);
        HttpCookie GenCookie(string UserName);
        // System.Web.HttpCookie GenCookie(string userName);
    }
}
