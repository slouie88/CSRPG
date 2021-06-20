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
            currentPlayer = new Player();
            currentPlayer.Name = "HDMaster88";
            currentPlayer.CharacterClass = "Sage";
            currentPlayer.HitPoints = 100;
            currentPlayer.ExperiencePoints = 0;
            currentPlayer.Gold = 100;
            currentPlayer.Level = 1;
        }
    }
}
