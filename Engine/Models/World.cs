using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();




        internal void AddLocation(int XCoordinate, int YCoordinate, string name, string description, string imageName)
        {
            //Location loc = new Location(XCoordinate, YCoordinate, name, description, imageName);
            Location loc = new Location
            {
                XCoordinate = XCoordinate,
                YCoordinate = YCoordinate,
                Name = name,
                Description = description,
                ImageName = imageName
            };
            _locations.Add(loc);
        }

        public Location LocationAt(int XCoordinate, int YCoordinate)
        {
            foreach (Location l in _locations)
            {
                if (l.XCoordinate == XCoordinate && l.YCoordinate == YCoordinate) return l;
            }

            return null;
        }
    }
}
