using System;

namespace RunningActivityTracker.Models
{
    public class RunningActivity
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Distance { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public TimeSpan Duration => EndTime - StartTime;
        public double AveragePace => Distance > 0 ? Duration.TotalMinutes / Distance : 0;
    }
}
