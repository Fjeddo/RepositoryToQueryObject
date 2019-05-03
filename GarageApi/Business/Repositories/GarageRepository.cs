using GarageApi.Business.Entities;

namespace GarageApi.Business.Repositories
{
    public class GarageRepository : IGarageRepository
    {
        public void CheckInVehicle(int garageId, Vehicle vehicle)
        {
            throw new System.NotImplementedException();
        }

        public void CheckOutVehicle(int garageId, string regNo)
        {
            throw new System.NotImplementedException();
        }

        public Garage GetGarage(int garageId)
        {
            throw new System.NotImplementedException();
        }

        public Vehicle GetVehicle(int garageId, string regNo)
        {
            throw new System.NotImplementedException();
        }
    }
}