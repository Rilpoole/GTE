using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SimpleKanbanOptimizer.Models
{
    public class Board
    {
        public string AccountUUID { get; set; }
        public string BoardUUId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Card> Draft {  get; set; }
        public List<Card> Pending { get; set; }
        public List<Card> InProgress { get; set; }
        public List<Card> Complete { get; set; }
        public List<Card> Issue { get; set; }
        public List<Card> Cancel { get; set; }
        public int Throughput { get; set; }
        public int ThroughputTrend { get; set; }
        public List<User> Users { get; set; }
    }
}
