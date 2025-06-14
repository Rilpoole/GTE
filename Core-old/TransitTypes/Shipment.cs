using Core.BusinessObjects;
using Core.People;
using Core.Places;

namespace Core.TransitTypes
{
    ///
    public class Shipment : Transit
    {
        public Shipment(int iD, Carrier carrier, Location start, Location end, int startDate, int completedDate, int cost)
        {
            ID = iD;
            Carrier = carrier ?? throw new ArgumentNullException(nameof(carrier));
            Start = start ?? throw new ArgumentNullException(nameof(start));
            End = end ?? throw new ArgumentNullException(nameof(end));
            StartDate = startDate;
            CompletedDate = completedDate;
            Cost = cost;
        }

        public int ID { get; private set; }
        public Carrier Carrier { get; private set; }
        public Location Start { get; private set; }
        public Location End { get; private set; }
        public int StartDate { get; private set; }
        public int CompletedDate { get; private set; }
        public int Cost { get; private set; }
    }
}
