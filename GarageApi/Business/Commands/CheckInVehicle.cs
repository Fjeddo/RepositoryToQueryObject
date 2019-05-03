namespace GarageApi.Business.Commands
{
    public class CheckInVehicle : ICommand
    {
        public int GarageId { get; }
        public string RegNo { get; }

        public CheckInVehicle(int garageId, string regNo)
        {
            GarageId = garageId;
            RegNo = regNo;
        }

        public void Execute(IDataAccess dataAccess)
        {
            throw new System.NotImplementedException();
        }
    }
}