

using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace WebDev_CourseWork1.Models
{
    public class OrganisationContext : DbContext
    {    
        public OrganisationContext(DbContextOptions<OrganisationContext> options)
        : base(options)
        { }

    
        public DbSet<Department> Department { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Employee_Skills> Employee_Skills { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Assignment> Task { get; set; }
    }

}



