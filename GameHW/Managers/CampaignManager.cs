using System;
using System.Collections.Generic;
using System.Text;
using GameHW.Interface;
namespace GameHW.Managers
{
    class CampaignManager : IManagerService<Campaign>
    {
        public void Add(Campaign input)
        {
            Console.WriteLine("Added new Campaign: "+input.CampaignName);
        }

        public void Delete(int ID)
        {
            Console.WriteLine("Deleted campaign with ID: " + ID);
        }

        public void Update(Campaign input)
        {
            Console.WriteLine(input.CampaignName + " is updated.");
        }
    }
}
