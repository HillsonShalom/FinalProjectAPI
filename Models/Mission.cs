using FinalProjectAPI.Services.BaseModels;

namespace FinalProjectAPI.Models
{
    public class Mission
    {
        public Agent Agent { get; set; }
        public int AgentId { get; set; }
        public Target Target { get; set; }
        public int TargetId { get; set; }
        public MissionStatus Status { get; set; } = MissionStatus.Offerd;
        public TimeSpan EstimatedTime { get; set; }
        public TimeSpan ExecutionTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExecutionDate { get; set; }
    }
}
