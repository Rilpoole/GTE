using Core.Objects;
using Core.People;

namespace Core.Documents
{
    ///
    public class Catalog
    {
        public Catalog(int iD, string name, string description, Vendor vendor, List<CatalogItem> catalogItems)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Vendor = vendor ?? throw new ArgumentNullException(nameof(vendor));
            CatalogItems = catalogItems ?? throw new ArgumentNullException(nameof(catalogItems));
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Vendor Vendor { get; private set; }
        public List<CatalogItem> CatalogItems { get; private set; }
    }
}
