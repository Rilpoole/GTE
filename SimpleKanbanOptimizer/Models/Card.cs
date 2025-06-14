using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SimpleKanbanOptimizer.Models
{
    public class Card
    {
        public string AccountUUID { get; set; }
        public string CardUUId { get; set; }
        public List<string> ReferenceIDs { get; set; }
        public List<Board> PossibleBoards { get; set; }
        public List<Card> Children { get; set; }
        public string Contents { get; set; }
        public string State { get; set; }
        public int Priority { get; set; }
        public string Due { get; set; }
        public string Started { get; set; }
        public string Completed { get; set; }
        public string Duration { get; set; }
        public List<File> Files { get; set; }
        public List<Note> Notes { get; set; }
    }
}
