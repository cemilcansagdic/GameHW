using System;
using System.Collections.Generic;
using System.Text;
using GameHW.Interface;
namespace GameHW.Models
{
    public class Game:IEntity
    {
        public int ID { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }

    }
}
