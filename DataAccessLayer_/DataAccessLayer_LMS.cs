using LmsApi.Modals;
using Microsoft.EntityFrameworkCore;

namespace LmsApi.DataAccessLayer_
{
    public class DataAccessLayer_LMS:DbContext
    {
        public DataAccessLayer_LMS(DbContextOptions<DataAccessLayer_LMS> options) : base(options)
        {

        }
        public DbSet<LeaveDbModal> Leave_Table { get; set; }
    }
}

