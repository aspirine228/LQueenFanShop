using System;
using System.Collections.Generic;
using System.Text;
using QueenFanShop.Models.Enteties.General;
using QueenFanShop.Models.Enteties.User;

namespace QueenFanShop.BuisnessLogic.Interfaces
{
    public interface ISession
    {
        ResponsMSG GetUserSession(USessionData udata);
    }
}
