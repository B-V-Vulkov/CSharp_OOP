namespace MilitaryElite.Contracts.Private
{
    using Enumerations;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
