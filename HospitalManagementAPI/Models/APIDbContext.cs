using Microsoft.EntityFrameworkCore;

namespace HospitalManagementAPI.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Staff> Staffs { get; set; }
    }
}
