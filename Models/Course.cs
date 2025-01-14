namespace CourseManagementAPI.Models
{
    public class Course
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Instructor { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
