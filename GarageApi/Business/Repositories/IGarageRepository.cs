using GarageApi.Business.Models;

namespace GarageApi.Business.Repositories
{
    public interface IGarageRepository
    {
        void CheckInVehicle(int garageId, Vehicle vehicle);
        void CheckOutVehicle(int garageId, string regNo);
        Garage GetGarage(int garageId);
        Vehicle GetVehicle(int garageId, string regNo);
    }
}