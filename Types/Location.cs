using System;
using System.Collections.Generic;
using System.Text;

namespace MockUberCore.Types
{
    public sealed class Location
    {
        public Location() { }
        public Location(int id, double latitude, double longitude)
        {
            LocationId = id;
            Latitude = latitude;
            Longitude = longitude;
        }
        public int LocationId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string ToString() => $"Id:{LocationId} latitude:{Latitude}, longitude:{Longitude}";
        
    }
}
