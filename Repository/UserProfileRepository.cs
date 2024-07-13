using Microsoft.EntityFrameworkCore;
using RunningActivityTracker.Data;
using RunningActivityTracker.Models;
using RunningActivityTracker.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RunningActivityTracker.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly AppDbContext _context;

        public UserProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserProfile>> GetAllUserProfiles()
        {
            return await _context.UserProfiles.ToListAsync();
        }

        public async Task<UserProfile> GetUserProfileById(int id)
        {
            return await _context.UserProfiles.FindAsync(id);
        }

        public async Task AddUserProfile(UserProfile userProfile)
        {
            _context.UserProfiles.Add(userProfile);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserProfile(UserProfile userProfile)
        {
            _context.UserProfiles.Update(userProfile);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserProfile(int id)
        {
            var userProfile = await _context.UserProfiles.FindAsync(id);
            if (userProfile != null)
            {
                _context.UserProfiles.Remove(userProfile);
                await _context.SaveChangesAsync();
            }
        }
    }
}
