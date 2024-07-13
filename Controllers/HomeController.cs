using Microsoft.AspNetCore.Mvc;
using RunningActivityTracker.Models;
using RunningActivityTracker.Services;
using System;
using System.Collections.Generic;

namespace RunningActivityTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfilesController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;

        public UserProfilesController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserProfile>> GetAllUserProfiles()
        {
            var profiles = _userProfileService.GetAllUserProfiles();
            return Ok(profiles);
        }

        [HttpGet("{id}")]
        public ActionResult<UserProfile> GetUserProfileById(int id)
        {
            var profile = _userProfileService.GetUserProfileById(id);
            if (profile == null)
            {
                return NotFound();
            }
            return Ok(profile);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserProfile(int id, UserProfile profile)
        {
            if (id != profile.Id)
            {
                return BadRequest();
            }
            _userProfileService.UpdateUserProfile(profile);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserProfile(int id)
        {
            _userProfileService.DeleteUserProfile(id);
            return NoContent();
        }
    }
}
