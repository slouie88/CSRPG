using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation { get; set; }

        public GameSession()
        {
         
            CurrentPlayer = new Player("HDMaster88", "Sage", 100, 0, 1, 100);

            CurrentLocation = new Location(0, -1, "Home", "Thunder Dragon Mountain", "image");

        }
    }
}
