using GarageApi.Business.Models;

namespace GarageApi.Business.Repositories
{
    public interface IGarageRepository
    {
        void CheckInVehicle(int garageId, Vehicle vehicle);
        void CheckOutVehicle(int garageId, string regNo);
        object GetGarage(int garageId);
    }
}