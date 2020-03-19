using QueenFanShop.BuisnessLogic.Core;
using QueenFanShop.BuisnessLogic.Interfaces;
using QueenFanShop.Models.Enteties.General;
using QueenFanShop.Models.Enteties.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueenFanShop.BuisnessLogic.LogicBL
{
    class SessionBL:UserApi,ISession
    {
        public ResponsMSG GetUserSession(USessionData udata)
        {
            return UserSession(udata);
        }
    }
}
