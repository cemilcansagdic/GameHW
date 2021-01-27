using System;
using System.Collections.Generic;
using System.Text;
using GameHW.Interface;

namespace GameHW.Managers
{
    class SalesManager 
    {
        public void Add(Sales input)
        {
            Console.WriteLine("Sold new game to " + input.user.FirstName+" with Price: "+input.Price);
        }


        public void Delete(int ID)
        {
            Console.WriteLine("Refunded Game");
        }

        public void Update(Sales input)
        {
            Console.WriteLine("Updated Sales");
        }


    }
}
