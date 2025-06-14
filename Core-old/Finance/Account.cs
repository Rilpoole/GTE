namespace Core.Finance
{
    ///
    public class Account
    {
        public Account(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
