using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Location
    {
        private int _XCoordinate;
        private int _YCoordinate;
        private string _name;
        private string _description;
        private string _imageName;


        public int XCoordinate
        {
            get
            {
                return _XCoordinate;
            }
            set
            {
                _XCoordinate = value;
            }
        }

        public int YCoordinate
        {
            get
            {
                return _YCoordinate;
            }
            set
            {
                _YCoordinate = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string ImageName
        {
            get
            {
                return _imageName;
            }
            set
            {
                _imageName = value;
            }
        }

    }
}
