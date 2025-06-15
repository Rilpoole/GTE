using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SimpleKanbanOptimizer.Models
{
    public class Card
    {
        public string AccountUUID { get; set; }
        public string CardUUId { get; set; }
        public List<string> ReferenceIDs { get; set; }
        public List<Card> Children { get; set; }
        public string Contents { get; set; }
        public string State { get; set; }
        public int Priority { get; set; }
        public int Effort { get; set; }
        public int Points { get; set; }
        public string Due { get; set; }
        public string Created { get; set; }
        public string EstDuration { get; set; }
        public string EstStart { get; set; }
        public string ActualStart { get; set; }
        public string EstComplete { get; set; }
        public string ActualComplete { get; set; }
        public List<File> Files { get; set; }
        public List<Note> Notes { get; set; }
        public List<User> Assigneees { get; set; }
    }
}
