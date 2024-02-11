namespace WebDev_CourseWork1.Models
{
    public class Employee_Skills
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public Employees? Employees { get; set; }
        public Skill? Skill { get; set; }
    }
}
