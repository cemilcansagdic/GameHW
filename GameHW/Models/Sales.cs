using System;
using System.Collections.Generic;
using System.Text;
using GameHW.Models;
using GameHW.Interface;
namespace GameHW
{
    public class Sales:IEntity
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public Gamer user { get; set; }
        public Game game { get; set; }

    }
}
