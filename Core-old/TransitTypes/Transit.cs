using Core.Places;

namespace Core.TransitTypes
{
    ///
    public class Transit
    {
        public Transit(int id, int startDate, int completeDate, Location startLocation, Location endLocation)
        {
            Id = id;
            StartDate = startDate;
            CompleteDate = completeDate;
            StartLocation = startLocation;
            EndLocation = endLocation;
        }

        public int Id { get; private set; }
        public int StartDate { get; private set; }
        public int CompleteDate { get; private set; }
        public Location StartLocation { get; private set; }
        public Location EndLocation { get; private protected set; }
    }
}
