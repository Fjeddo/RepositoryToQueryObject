using System.Linq;
using GarageApi.Business.Entities;

namespace GarageApi.Business.Queries
{
    public class VehicleByGarageAndRegNo : IQuery<Domain.Vehicle>
    {
        public int GarageId { get; }
        public string RegNo { get; }

        public VehicleByGarageAndRegNo(int garageId, string regNo)
        {
            GarageId = garageId;
            RegNo = regNo;
        }

        public Domain.Vehicle Execute(IDataAccess dataAccess)
        {
            dynamic @object = dataAccess.Query<Vehicle>(v => v.RegNo == RegNo /*&& v.InGarage == GarageId*/, v => new {v.RegNo}).Single();

            return new Domain.Vehicle(@object.RegNo);
        }
    }
}