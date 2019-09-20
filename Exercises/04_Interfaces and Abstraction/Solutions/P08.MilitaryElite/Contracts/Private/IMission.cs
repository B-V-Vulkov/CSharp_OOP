namespace MilitaryElite.Contracts.Private
{
    using Enumerations;

    public interface IMission 
    {
        string CodeName { get; }

        MissionState MissionState { get; }

        void CompleteMission();
    }
}
