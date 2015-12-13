namespace Empires.Models.Interfaces
{
    public interface IResource
    {
        int Quantity { get; }
        ResourceType Type { get; }
    }
}
