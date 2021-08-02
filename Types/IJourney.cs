using System;
using System.Collections.Generic;
using System.Text;

namespace MockUberCore.Types
{
    public interface IJourney
    {
        Location CurrentLocation { get; }

        void UpdateCurrentLocation(double longitude, double latitude);
        void EndJourney();
        void StartJourney(Taxi taxiId);
    }
}
