using RunningActivityTracker.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RunningActivityTracker.Repositories
{
    public interface IUserProfileRepository
    {
        Task<IEnumerable<UserProfile>> GetAllUserProfiles();
        Task<UserProfile> GetUserProfileById(int id);
        Task AddUserProfile(UserProfile userProfile);
        Task UpdateUserProfile(UserProfile userProfile);
        Task DeleteUserProfile(int id);
    }
}
