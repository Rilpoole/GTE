namespace Core.Documents
{
    ///
    internal class Requistion
    {
        public Requistion(int id, List<RequisitionItem> requisitionItems)
        {
            Id = id;
            this.requisitionItems = requisitionItems;
        }

        public int Id { get; private set; }
        public List<RequisitionItem> requisitionItems { get; private set; }
    }
}
