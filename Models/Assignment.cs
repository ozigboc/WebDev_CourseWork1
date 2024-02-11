namespace WebDev_CourseWork1.Models
{
    public class Assignment
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
       public int? Deadline { get; set; }
        public string? Description { get; set; }
        public Project? Project { get; set; }
       
    }
}
