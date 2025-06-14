namespace Core.Documents
{
    ///
    public class BillOfMaterials
    {
        private int ID {  get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private List<BillOfMaterialsItem> BillOfMaterialsItems { get; set; }

        public BillOfMaterials(int iD, string name, string description, List<BillOfMaterialsItem> billOfMaterialsItems)
        {
            ID = iD;
            Name = name;
            Description = description;
            BillOfMaterialsItems = billOfMaterialsItems;
        }
    }
}
