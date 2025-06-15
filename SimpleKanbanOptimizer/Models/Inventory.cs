namespace SimpleKanbanOptimizer.Models
{
    public class Inventory
    {
        public string AccountUUID { get; set; }
        public string InventoryUUID { get; set; }
        public int Qty { get; set; }
        public Item Item { get; set; }
        public Location Location { get; set; }
    }
}
