
namespace Core.People
{
    ///
    public class Vendor
    {
        public Vendor(int iD, string name, string description)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
