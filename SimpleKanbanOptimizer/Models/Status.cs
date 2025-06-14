namespace SimpleKanbanOptimizer.Models
{
    public class Status
    {
        public string AccountUUID { get; set; }
        public string StatusUUId { get; set; }
        public Card Card { get; set; }
        public string EstCompletion { get; set; }
    }
}
