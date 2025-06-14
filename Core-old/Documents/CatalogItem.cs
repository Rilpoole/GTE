using Core.Objects;

namespace Core.Documents
{
    ///
    public class CatalogItem
    {
        public CatalogItem(Item item, int price, int qty)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Price = price;
            Qty = qty;
        }

        public Item Item { get; private set; }
        public int Price { get; private set; }
        public int Qty { get; private set; }
    }
}
