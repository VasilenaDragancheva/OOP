namespace Empires.Models.Interfaces
{
    public interface IBuilding
    {
        IUnit ProduceUnit();
        IResource ProduceResource();
        int TurnsAfterCreation { get; set; }

    }
}
