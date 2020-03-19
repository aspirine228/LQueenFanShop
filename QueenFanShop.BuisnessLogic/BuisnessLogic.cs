using QueenFanShop.BuisnessLogic.Interfaces;
using QueenFanShop.BuisnessLogic.LogicBL;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueenFanShop.BuisnessLogic
{
   public class BuisnessLogic
    { public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
