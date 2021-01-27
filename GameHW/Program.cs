using GameHW.Managers;
using System;
using System.Collections.Generic;
using GameHW.Models;
namespace GameHW
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager();
            Game game = new Game { ID = 1, GameName = "Witcher 3", GameType = "RPG" };
            Campaign campaign = new Campaign {ID=1, CampaignName="Summer Sales" };
            User gamer = new Gamer { ID = 1, FirstName = "Cemilcan", LastName = "Sağdıç", TCNo = "12345678910" };
            Sales sales = new Sales();
            sales.ID = 1;
            sales.game = game;
            sales.Price = 120;
            sales.user = (Gamer)gamer;
            salesManager.Add(sales);
            Console.Read();
        }


    }
}
