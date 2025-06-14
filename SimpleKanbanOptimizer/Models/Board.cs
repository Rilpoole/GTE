namespace SimpleKanbanOptimizer.Models
{
    public class Board
    {
        public string AccountUUID { get; set; }
        public string BoardUUId { get; set; }
        public string Description { get; set; }
        public List<Card> ToDo { get; set; }
        public List<Card> InProgress { get; set; }
        public List<Card> Complete { get; set; }
        public int Throughput { get; set; }
        public int ThroughputTrend { get; set; }
    }
}
