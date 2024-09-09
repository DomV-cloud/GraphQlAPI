namespace GraphQlAPI.Schema.Queries
{
    public class CourseType : BaseType
    {
        public string Name { get; set; } = string.Empty;

        public Subject Subject { get; set; }

        public InstructorType Instructor { get; set; } = null!;

        public IEnumerable<StudentType> Students { get; set; } = [];

        public string Description => $"{Name}: This is a course";
    }

    public enum Subject
    {
        Mathematics,
        Science,
        Programming
    }
}
