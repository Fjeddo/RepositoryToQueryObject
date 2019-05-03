namespace GarageApi.Business.Commands
{
    public interface ICommand
    {
        void Execute(IDataAccess dataAccess);
    }
}
