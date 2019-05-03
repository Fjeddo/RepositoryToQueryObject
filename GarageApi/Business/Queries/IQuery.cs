namespace GarageApi.Business.Queries
{
    public interface IQuery<T>
    {
        T Execute(IDataAccess dataAccess);
    }
}