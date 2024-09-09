namespace GraphQlAPI.Schema.Queries
{
    public class InstructorType : BaseType
    {
        public string FirsName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public decimal Salary { get; set; }
    }
}
