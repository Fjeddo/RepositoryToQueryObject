using System.Collections.Generic;
using System.Linq;
using GarageApi.Business.Entities;

namespace GarageApi.Business.Queries
{
    public class GarageById : IQuery<Domain.Garage>
    {
        public int Id { get; }

        public GarageById(int id)
        {
            Id = id;
        }

        public Domain.Garage Execute(IDataAccess dataAccess)
        {
            dynamic @object = dataAccess.Query<Garage>(g => g.Id == Id, g => new {g.Id, g.Name}).SingleOrDefault();

            return @object == null ? throw new KeyNotFoundException() : new Domain.Garage(@object.Id, @object.Name);
        }
    }
}