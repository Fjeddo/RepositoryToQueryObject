using System.Collections.Generic;

namespace GarageApi.Business.Entities
{
    public class Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}