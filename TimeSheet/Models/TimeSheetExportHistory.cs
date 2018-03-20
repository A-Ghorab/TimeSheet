using System;

namespace TimeSheet.Models
{
    public class TimeSheetExportHistory
    {
        public long Id { get; set; }
        public TimeSpan createdAt { get; set; }
        public TimeSpan exportedInfoStartDate { get; set; }
        public TimeSpan exportedInfoEndDate { get; set; }
        // Navigation Properties
        public long userId { get; set; }
        public virtual User user { get; set; }
        public virtual SavedFile savedFile { get; set; }
    }
}
