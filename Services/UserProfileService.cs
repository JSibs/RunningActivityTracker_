using RunningActivityTracker.Models;
using RunningActivityTracker.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RunningActivityTracker.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _repository;

        public UserProfileService(IUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<UserProfile>> GetAllUserProfiles()
        {
            return await _repository.GetAllUserProfiles();
        }

        public async Task<UserProfile> GetUserProfileById(int id)
        {
            return await _repository.GetUserProfileById(id);
        }

        public async Task AddUserProfile(UserProfile userProfile)
        {
            await _repository.AddUserProfile(userProfile);
        }

        public async Task UpdateUserProfile(UserProfile userProfile)
        {
            await _repository.UpdateUserProfile(userProfile);
        }

        public async Task DeleteUserProfile(int id)
        {
            await _repository.DeleteUserProfile(id);
        }
    }
}
