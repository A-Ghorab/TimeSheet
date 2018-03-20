using System;
using System.Collections.Generic;

namespace TimeSheet.Models
{
    public class User
    {
        public long Id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String magic { get; set; }
        public TimeSpan createdAt { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public bool isSuspended { get; set; }
        // Navigation Properties
        public virtual ICollection<Project> linkedProjects { get; set; }
        public virtual ICollection<TimeSheetEntry> timeSheetEntries { get; set; }
        public virtual ICollection<TimeSheetExportHistory> timeSheetExportHistories { get; set; }
    }
}
