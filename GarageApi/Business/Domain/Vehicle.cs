namespace GarageApi.Business.Domain
{
    public class Vehicle
    {
        public string RegNo { get; }

        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }
    }
}
