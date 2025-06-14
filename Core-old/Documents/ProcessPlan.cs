

namespace Core.Documents
{
    ///
    public class ProcessPlan
    {
        public ProcessPlan(int iD, string name, string description, BillOfMaterials billOfMaterials, OperationsSheet operationsSheet)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            BillOfMaterials = billOfMaterials ?? throw new ArgumentNullException(nameof(billOfMaterials));
            OperationsSheet = operationsSheet ?? throw new ArgumentNullException(nameof(operationsSheet));
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public BillOfMaterials BillOfMaterials { get; private set; }
        public OperationsSheet OperationsSheet { get; private set; }
    }
}
