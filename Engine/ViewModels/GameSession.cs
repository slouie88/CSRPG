using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player currentPlayer { get; set; }

        public GameSession()
        {
         
            currentPlayer = new Player("HDMaster88", "Sage", 100, 0, 1, 100);

        }
    }
}
