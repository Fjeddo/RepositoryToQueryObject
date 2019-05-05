using System.Collections.Generic;

namespace GarageApi.Business.Domain
{
    public class Garage
    {
        public int Id { get; }
        public string Name { get; }
        public IEnumerable<Vehicle> Vehicles { get; }

        public Garage(int id, string name, IEnumerable<Vehicle> vehicles)
        {
            Id = id;
            Name = name;
            Vehicles = vehicles;
        }
    }
}
