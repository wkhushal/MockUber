using System;
using System.Collections.Generic;
using System.Text;

namespace MockUberCore.Types
{
    public sealed class Passenger
    {
        public Passenger(int id, string name, string phoneNumber)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
        }

        public int Id { get; }
        public string Name { get; }
        public string PhoneNumber { get; }
    }
}
