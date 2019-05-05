using System.ComponentModel.DataAnnotations.Schema;

namespace GarageApi.Business.Entities
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int Id { get; set; }
        public string RegNo { get; set; }

        public Garage Garage { get; set; }
    }
}   