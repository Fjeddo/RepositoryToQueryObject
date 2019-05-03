namespace GarageApi.Business.Domain
{
    public class Garage
    {
        public int Id { get; }
        public string Name { get; }

        public Garage(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
