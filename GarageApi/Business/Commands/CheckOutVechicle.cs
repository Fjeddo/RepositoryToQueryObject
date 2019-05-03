namespace GarageApi.Business.Commands
{
    public class CheckOutVechicle : ICommand
    {
        public int GarageId { get; }
        public string RegNo { get; }

        public CheckOutVechicle(int garageId, string regNo)
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