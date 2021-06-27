using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation { get; set; }

        public World CurrentWorld { get; set; }

        public GameSession()
        {
         
            CurrentPlayer = new Player("HDMaster88", "Sage", 100, 0, 1, 100);

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);

        }
    }
}
