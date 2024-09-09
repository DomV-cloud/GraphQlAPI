using Bogus;
using GraphQlAPI.Schema.Queries;

namespace GraphQlAPI.MockData
{
    public class MockDataFaker
    {
        private Faker<InstructorType> instructorFaker;
        private Faker<StudentType> studentFaker;
        private Faker<CourseType> courseFaker;

        public MockDataFaker()
        {
            instructorFaker = new Faker<InstructorType>()
                .RuleFor(i => i.Id, f => Guid.NewGuid())
                .RuleFor(i => i.FirsName, f => f.Name.FirstName())
                .RuleFor(i => i.LastName, f => f.Name.LastName())
                .RuleFor(i => i.Salary, f => f.Finance.Amount(30000, 100000));

            studentFaker = new Faker<StudentType>()
                .RuleFor(s => s.Id, f => Guid.NewGuid())
                .RuleFor(s => s.FirsName, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s => s.GPA, f => f.Random.Double(0, 4));

            courseFaker = new Faker<CourseType>()
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Commerce.ProductName())
                .RuleFor(c => c.Subject, f => f.PickRandom<Subject>())
                .RuleFor(c => c.Instructor, f => instructorFaker.Generate())
                .RuleFor(c => c.Students, f => studentFaker.Generate(10));
        }

        public CourseType GenerateCourse()
        {
            return courseFaker.Generate();
        }

        public IEnumerable<CourseType> GenerateCourses(int numberOfCourses)
        {
            return courseFaker.Generate(numberOfCourses);
        }
    }
}
