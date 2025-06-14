namespace Core.Objects
{
    ///
    public class Equipment
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Equipment(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }
    }
}
