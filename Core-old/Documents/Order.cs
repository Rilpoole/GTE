using Core.People;
using Core.Places;

namespace Core.Documents
{
    ///
    public class Order
    {
        public Order(int id, List<OrderItem> items)
        {
            Id = id;
            Items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public int Id { get; private set; }
        public List<OrderItem> Items { get; private set; }
    }
}
