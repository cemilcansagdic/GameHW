using System;
using System.Collections.Generic;
using System.Text;
using GameHW.Interface;

namespace GameHW.Managers
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool Check(User user)
        {
            if (user.FirstName == null && user.LastName == null && user.TCNo == null && user.YearOfBirth != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
