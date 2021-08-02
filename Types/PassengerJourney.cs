using System;

namespace MockUberCore.Types
{
    public class PassengerJourney : IJourney
    {
        public PassengerJourney(int passengerId, Location startLocation, Location endLocation)
        {
            PassengerId = passengerId;
            StartLocation = startLocation;
            EndLocation = endLocation;
            OnBoard = false;
        }

        public int PassengerId { get; }
        public Location StartLocation { get; }
        public Location EndLocation { get; }
        public Location CurrentLocation { get; private set; }
        public Taxi Taxi { get; private set; }

        public bool OnBoard { get; private set; }

        public void EndJourney()
        {
            OnBoard = false;
            Taxi = null;
        }

        public void StartJourney(Taxi taxi)
        {
            OnBoard = true;
            Taxi = taxi;
        }

        public void UpdateCurrentLocation(double longitude, double latitude)
        {
            CurrentLocation = new Location(new Random().Next(), latitude, longitude);
        }
    }
}
