using Core.BusinessObjects;
using Core.Objects;
using Core.Places;

namespace Core.TransitTypes
{
    ///
    public class InternalTransit : Transit
    {
        public InternalTransit(int iD, List<LaborItem> laborItems, Location start, Location end, int startDate, int completedDate)
        {
            ID = iD;
            LaborItems = laborItems ?? throw new ArgumentNullException(nameof(laborItems));
            Start = start ?? throw new ArgumentNullException(nameof(start));
            End = end ?? throw new ArgumentNullException(nameof(end));
            StartDate = startDate;
            CompletedDate = completedDate;
        }

        public int ID { get; private set; }
        public List<LaborItem> LaborItems { get; private set; }
        public Location Start { get; private set; }
        public Location End { get; private set; }
        public int StartDate { get; private set; }
        public int CompletedDate { get; private set; }
    }
}
