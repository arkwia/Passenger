using System;

namespace Passenger.Core.Domain
{
    public class Vehicle
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int Seats { get; protected set; }

        public Vehicle(string brand, string name, int seats)
        {
            SetBrand(brand);
            SetName(name);
            SetSeats(seats);
        }

        private void SetBrand(string brand)
        {
            if(string.IsNullOrWhiteSpace(brand))
            {
                throw new Exception("Brand of vehicle cannot be null or whitespace.");
            }
            Brand = brand;
        }
        private void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name of vehicle cannot be null or whitespace.");
            }
            Name = name;
        }
        private void SetSeats(int seats)
        {
            if(seats < 1)
            {
                throw new Exception("Number of seats cannot be less than 1.");
            }
            if(seats > 9)
            {
                throw new Exception("Number of seats cannot be greater than 9.");
            }
            Seats = seats;
        }
    }
}