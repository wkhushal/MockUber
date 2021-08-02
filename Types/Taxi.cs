using System;
using System.Collections.Generic;
using System.Text;

namespace MockUberCore.Types
{
    public sealed class Taxi
    {
        public Taxi() { }
        public Taxi(int id, Location startLocation)
        {
            TaxiId = id;
            CurrentLocation = startLocation ?? throw new ArgumentNullException(nameof(startLocation));
            IsOccupied = false;
        }

        public int TaxiId { get; set; }
        public bool IsOccupied { get; set; }
        public Location CurrentLocation { get; set; }

        public void ToggleOccupied()
        {
            IsOccupied |= IsOccupied;
        }
    }
}
