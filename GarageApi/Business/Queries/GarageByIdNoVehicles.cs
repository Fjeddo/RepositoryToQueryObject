using GarageApi.Business.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GarageApi.Business.Queries
{
    public class GarageByIdNoVehicles : IQuery<Domain.Garage>
    {
        public int Id { get; }

        public GarageByIdNoVehicles(int id)
        {
            Id = id;
        }

        public Domain.Garage Execute(IDataAccess dataAccess)
        {
            dynamic @object = dataAccess.Query<Garage>(
                g => g.Id == Id,
                g => new {g.Id, g.Name}).SingleOrDefault();

            if (@object == null)
            {
                throw new KeyNotFoundException();
            }

            var domainGarage = new Domain.Garage(@object.Id, @object.Name, null);

            return domainGarage;

        }
    }
}