using Core.BusinessObjects;
using Core.Objects;
using Core.Places;

namespace Core.TransitTypes
{
    ///
    public class Pickup : Transit
    {
        public Pickup(int iD, List<LaborItem> laborItems, Location start, Location end, int startDate, int completedDate)
        {
            ID = iD;
            LaborItems = laborItems;
            Start = start;
            End = end;
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
