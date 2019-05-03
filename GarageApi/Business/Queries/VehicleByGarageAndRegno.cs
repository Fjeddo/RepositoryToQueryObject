using GarageApi.Business.Models;

namespace GarageApi.Business.Queries
{
    public class VehicleByGarageAndRegNo : IQuery<Vehicle>
    {
        public int GarageId { get; }
        public string RegNo { get; }

        public VehicleByGarageAndRegNo(int garageId, string regNo)
        {
            GarageId = garageId;
            RegNo = regNo;
        }

        public Vehicle Execute(IDataAccess dataAccess)
        {
            throw new System.NotImplementedException();
        }
    }
}