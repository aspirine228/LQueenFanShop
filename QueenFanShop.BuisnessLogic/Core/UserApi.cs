using QueenFanShop.Models.Enteties.General;
using QueenFanShop.Models.Enteties.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueenFanShop.BuisnessLogic.Core
{
    public class UserApi
    {


        internal ResponsMSG UserSession(USessionData udata)
        {
            UDbTable user;

            using (var db = new UserContext())
            {

                user = db.Users.FirstOrDefault(u => u.Username == udata.Credential);
            }

            using (var db = new UserContext())
            {
                user = (from u in db.Users where u.Username == udata.Credential select u).FirstOrDefault();
            }


            if (user != null)
            {

            }


            return new ResponsMSG();
        }

    }
}