namespace SimpleKanbanOptimizer.Models
{
    public class Status
    {
        public string AccountUUID { get; set; }
        public string StatusUUId { get; set; }
        public string Timestamp { get; set; }
        public string CardUUID { get; set; }
        public string State { get; set; }
        public int Priority { get; set; }
        public string Due { get; set; }
        public string EstCompletion { get; set; }
    }
}
