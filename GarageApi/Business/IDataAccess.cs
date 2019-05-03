using GarageApi.Business.Queries;

namespace GarageApi.Business
{
    public interface IDataAccess
    {
        T Query<T>(IQuery<T> query);
    }
}
