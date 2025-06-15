using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SimpleKanbanOptimizer.Models
{
    public class LogEntry
    {
        public string AccountUUID { get; set; }
        public string LogEntryUUID { get; set; }
        public string UserUUID { get; set; }
        public string CardUUID {  get; set; }
        public string Contents {  get; set; }
    }
}
