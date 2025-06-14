using Core.BusinessObjects;
using Core.Objects;
using Core.Places;

namespace Core.TransitTypes
{
    ///
    public class Delivery : Transit
    {
        public Vehicle Vehicle { get; private set; }
        public List<LaborItem> LaborItems { get; private set; }
    }
}
