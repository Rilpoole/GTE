using Core.People;
using Core.Places;

namespace Core.TransitTypes 
{
    ///
    public class Willcall : Transit
    {
        public Willcall(int iD, Location pickupLocation, int pickupDate)
        {
            ID = iD;
            PickupLocation = pickupLocation ?? throw new ArgumentNullException(nameof(pickupLocation));
            PickupDate = pickupDate;
        }

        public int ID { get; private set; }
        public Location PickupLocation { get; private set; }
        public int PickupDate { get; private set; }
    }
}
