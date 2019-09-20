namespace MilitaryElite.Contracts.Private
{
    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}
