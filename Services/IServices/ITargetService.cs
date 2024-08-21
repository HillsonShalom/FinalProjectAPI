using FinalProjectAPI.Models;
using System.Drawing;

namespace FinalProjectAPI.Services.IServices
{
    /// <summary>
    /// a service interface that provide all necessary actions for Targets table
    /// </summary>
    public interface ITargetService
    {
        Task<int> CreateTarget(string name, string role, string image);
        Task<int> CreateTarget(Target target);
        Task UpdateTarget(Target target);
        Task Delete(int id);

        
        Task<IEnumerable<Target>> GetTargets();
        Task<Target> GetTarget(int id);
        Task Move(int x, int y);
        Task InitializeLocation(Target target, Point point);
    }
}
