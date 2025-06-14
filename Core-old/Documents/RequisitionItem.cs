using Core.Objects;
using Core.People;
using Core.Places;
using Core.TransitTypes;

namespace Core.Documents
{
    ///
    internal class RequisitionItem
    {
        public RequisitionItem(Vendor vendor, Location location, int qty, Item item, int orderDate, int completedDate, Transit transitType)
        {
            Vendor = vendor;
            Location = location;
            Qty = qty;
            Item = item;
            OrderDate = orderDate;
            CompletedDate = completedDate;
            TransitType = transitType;
        }

        public Vendor Vendor { get; set; }
        public Location Location { get; set; }
        public int Qty { get; private set; }
        public Item Item { get; private set; }
        public int OrderDate { get; private set; }
        public int CompletedDate { get; private set; }
        public Transit TransitType { get; private set; }
    }
}
