namespace SimpleKanbanOptimizer.Models
{
    public class User
    {
        public string AccountUUID { get; set; }
        public string UserUUId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public Availability Availability { get; set; }
    }
}
