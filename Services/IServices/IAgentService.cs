using FinalProjectAPI.Models;
using System.Drawing;

namespace FinalProjectAPI.Services.IServices
{
    /// <summary>
    /// a service interface that provide all necessary actions for Agents table
    /// </summary>
    public interface IAgentService
    {
        Task<int> CreateTarget(string name, string image);
        Task<int> CreateTarget(Agent agent);
        Task UpdateTarget(Agent agent);
        Task Delete(int id);


        Task<IEnumerable<Agent>> GetTargets();
        Task<Agent> GetTarget(int id);
        Task Move(int x, int y);
        Task InitializeLocation(Agent agent, Point point);
    }
}
