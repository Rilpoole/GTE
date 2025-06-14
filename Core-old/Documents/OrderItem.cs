using Core.Objects;
using Core.People;
using Core.Places;
using Core.TransitTypes;

namespace Core.Documents
{
    ///
    public class OrderItem
    {
        public OrderItem(Customer customer, Location location, int qty, Item item, PriorityType priority, int dueDate, int orderDate, int completedDate, bool forPickup, Transit transitType)
        {
            Customer = customer ?? throw new ArgumentNullException(nameof(customer));
            Location = location ?? throw new ArgumentNullException(nameof(location));
            Qty = qty;
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Priority = priority;
            DueDate = dueDate;
            OrderDate = orderDate;
            CompletedDate = completedDate;
            ForPickup = forPickup;
            TransitType = transitType ?? throw new ArgumentNullException(nameof(transitType));
        }

        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public int Qty { get; private set; }
        public Item Item { get; private set; }
        public PriorityType Priority { get; private set; }
        public int DueDate { get; private set; }
        public int OrderDate { get; private set; }
        public int CompletedDate { get; private set; }
        public Boolean ForPickup { get; private set; }
        public Transit TransitType { get; private set; }
    }
}
