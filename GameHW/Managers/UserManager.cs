using System;
using System.Collections.Generic;
using System.Text;
using GameHW.Interface;


namespace GameHW.Managers
{
    class UserManager : IManagerService<User>
    {
        public PlayerCheckManager playerCheckManager= new PlayerCheckManager();
        public void Add(User input)
        {
            Console.WriteLine("User updated: " + input.FirstName + " " + input.LastName);
        }

        public void Delete(int ID)
        {
            Console.WriteLine("User Deleted with ID: " + ID);
        }

        public void Update(User input)
        {
            Console.WriteLine("User Updated: "+input.FirstName+" "+input.LastName );
        }

        public bool Check(User user)
        {
            return playerCheckManager.Check(user);
        }
    }
}
