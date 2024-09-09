namespace GraphQlAPI.Schema.Queries
{
    public class StudentType : BaseType
    {
        public string FirsName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        [GraphQLName("gpa")]
        public double GPA { get; set; }
    }
}
