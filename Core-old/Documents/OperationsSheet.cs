
namespace Core.Documents
{
    ///
    public class OperationsSheet
    {
        public OperationsSheet(string iD, string name, string description, List<OperationsSheetItem> items)
        {
            ID = iD ?? throw new ArgumentNullException(nameof(iD));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<OperationsSheetItem> Items { get; private set; }
    }
}
