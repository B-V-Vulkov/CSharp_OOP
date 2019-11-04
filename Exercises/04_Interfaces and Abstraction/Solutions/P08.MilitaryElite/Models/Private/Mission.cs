namespace MilitaryElite.Models.Private
{
    using System;

    using Contracts.Private;
    using Enumerations;
    using Exceptions;

    public class Mission : IMission
    {
        public Mission(string codeName, string missionState)
        {
            this.CodeName = codeName;
            ParseMissionState(missionState);
        }

        public string CodeName { get; }

        public MissionState MissionState { get; private set; }

        public void CompleteMission()
        {
            this.MissionState = MissionState.Finished;
        }

        private void ParseMissionState(string state)
        {
            MissionState missionState;

            bool isExist = Enum.TryParse<MissionState>(state, out missionState);

            if (!isExist)
            {
                throw new InvalidMissionStateException();
            }

            this.MissionState = missionState;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.MissionState}";
        }
    }
}
