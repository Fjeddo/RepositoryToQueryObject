using GarageApi.Business.Models;

namespace GarageApi.Business.Queries
{
    public class GarageById : IQuery<Garage>
    {
        public int Id { get; }

        public GarageById(int id)
        {
            Id = id;
        }

        public Garage Execute(IDataAccess dataAccess)
        {
            throw new System.NotImplementedException();
        }
    }
}
