using System;

namespace TimeSheet.Models
{
    public class TimeSheetEntry
    {
        public long Id { get; set; }
        public float hoursLogged { get; set; }
        public TimeSpan dateTime { get; set; }
        // Navigation Properties
        public long projectId { get; set; }
        public virtual Project project { get; set; }
        public long userId { get; set; }
        public virtual User user { get; set; }
    }
}
