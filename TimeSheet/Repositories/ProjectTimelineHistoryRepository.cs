using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimeSheet.Models;
using TimeSheet.Utilities;

namespace TimeSheet.Repositories
{
    public class ProjectTimelineHistoryRepository : GenericRepository<ProjectTimelineHistory>
    {
        public ProjectTimelineHistoryRepository(GenericContext dbContext) : base(dbContext)
        {
        }
    }
}
