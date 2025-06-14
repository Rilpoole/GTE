using Core.Documents;

namespace Core.Objects
{
    ///
    public class Item
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ProcessPlan ProcessPlan { get; private set; }

        public Item(int iD, string name, string description, ProcessPlan processPlan)
        {
            ID = iD;
            Name = name;
            Description = description;
            ProcessPlan = processPlan;
        }
    }
}
