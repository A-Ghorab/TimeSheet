using System;
using System.Collections.Generic;

namespace TimeSheet.Models
{
    public class Project
    {
        public long Id { get; set; }
        public String name { get; set; }
        public String projectManagerName { get; set; }
        public bool isActive { get; set; }
        // Navigation Properties
        public long userId { get; set; }
        public virtual User user { get; set; }
        public long projectId { get; set; }
        public virtual ICollection<ProjectTimelineHistory> projectTimelineHistories { get; set; }
        public virtual ICollection<TimeSheetEntry> timeSheetEntries { get; set; }
    }
}
