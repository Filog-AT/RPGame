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
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
        }
    }
}
