using EstateAgency.Models.Estates;

namespace EstateAgency.Models.Interfaces
{
    public interface IEstate
    {
        string Name { get; }
        EstateType EstateType { get; }
        double Area { get; }
        string Location { get; }
        bool Furniture { get; }

    }
}
