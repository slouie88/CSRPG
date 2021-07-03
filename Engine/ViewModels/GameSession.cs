using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotifcationClass
    {
        private Location _currentLocation;

        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToSouth));
            }
        }

        public bool HasLocationToNorth
        {
            get
            {
                int currentXCoordinate = CurrentLocation.XCoordinate;
                int currentYCoordinate = CurrentLocation.YCoordinate;
                Location newLocation = CurrentWorld.LocationAt(currentXCoordinate, currentYCoordinate + 1);
                return newLocation != null;
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                int currentXCoordinate = CurrentLocation.XCoordinate;
                int currentYCoordinate = CurrentLocation.YCoordinate;
                Location newLocation = CurrentWorld.LocationAt(currentXCoordinate - 1, currentYCoordinate);
                return newLocation != null;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                int currentXCoordinate = CurrentLocation.XCoordinate;
                int currentYCoordinate = CurrentLocation.YCoordinate;
                Location newLocation = CurrentWorld.LocationAt(currentXCoordinate + 1, currentYCoordinate);
                return newLocation != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                int currentXCoordinate = CurrentLocation.XCoordinate;
                int currentYCoordinate = CurrentLocation.YCoordinate;
                Location newLocation = CurrentWorld.LocationAt(currentXCoordinate, currentYCoordinate - 1);
                return newLocation != null;
            }
        }

        public World CurrentWorld { get; set; }

        public GameSession()
        {
         
            CurrentPlayer = new Player("HDMaster88", "Sage", 100, 0, 1, 100);

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);

        }







        public void MoveNorth()
        {
            int currentXCoordinate = CurrentLocation.XCoordinate;
            int currentYCoordinate = CurrentLocation.YCoordinate;

            Location newLocation = CurrentWorld.LocationAt(currentXCoordinate, currentYCoordinate + 1);

            CurrentLocation = newLocation;
        }

        public void MoveWest()
        {
            int currentXCoordinate = CurrentLocation.XCoordinate;
            int currentYCoordinate = CurrentLocation.YCoordinate;

            Location newLocation = CurrentWorld.LocationAt(currentXCoordinate - 1, currentYCoordinate);

            CurrentLocation = newLocation;
        }

        public void MoveEast()
        {
            int currentXCoordinate = CurrentLocation.XCoordinate;
            int currentYCoordinate = CurrentLocation.YCoordinate;

            Location newLocation = CurrentWorld.LocationAt(currentXCoordinate + 1, currentYCoordinate);

            CurrentLocation = newLocation;
        }

        public void MoveSouth()
        {
            int currentXCoordinate = CurrentLocation.XCoordinate;
            int currentYCoordinate = CurrentLocation.YCoordinate;

            Location newLocation = CurrentWorld.LocationAt(currentXCoordinate, currentYCoordinate - 1);

            CurrentLocation = newLocation;
        }
    }
}
