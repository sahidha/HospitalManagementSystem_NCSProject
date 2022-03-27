using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementAPI.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Staff> staffs { get; set; }
    }
}
