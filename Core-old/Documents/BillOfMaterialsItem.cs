
namespace Core.Documents
{
    ///
    public class BillOfMaterialsItem
    {
        public BillOfMaterialsItem(int qty, string itemID)
        {
            Qty = qty;
            ItemID = itemID ?? throw new ArgumentNullException(nameof(itemID));
        }

        private int Qty { get; set; }
        private string ItemID { get; set; }
    }
}
