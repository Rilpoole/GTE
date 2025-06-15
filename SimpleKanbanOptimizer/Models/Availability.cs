using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SimpleKanbanOptimizer.Models
{
    public class Availability
    {
        public string AccountUUID { get; set; }
        public string AvailabilityUUId { get; set; }
        public string Timestamp { get; set; }
        public string DayOfWeek { get; set; }
        public string In {  get; set; }
        public string Out { get; set; }
    }
}
