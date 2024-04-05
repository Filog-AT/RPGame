using GameEngine.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameSession
{
    public class Session
    {
        public Entity CurrentPlayer { get; set; }
        public Session()
        {
            CurrentPlayer = new Entity();
            CurrentPlayer.Name = "Bro";
            CurrentPlayer.CharacterClass = "Swordsman";
            CurrentPlayer.HitPoints = 0;
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.ExperiencePoints = 10;
            CurrentPlayer.Level = 1;
        }
    }
}
