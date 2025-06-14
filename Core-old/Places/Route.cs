
namespace Core.Places
{
    ///
    public class Route
    {
        public Route(int iD, string name, string description, Location start, Location end)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Start = start ?? throw new ArgumentNullException(nameof(start));
            End = end ?? throw new ArgumentNullException(nameof(end));
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Location Start {  get; private set; }
        public Location End { get; private set; }
    }
}
