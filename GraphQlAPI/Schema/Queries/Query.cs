using Bogus;
using GraphQlAPI.MockData;

namespace GraphQlAPI.Schema.Queries
{
    public class Query
    {
        private MockDataFaker _mockDataFaker = new();
        public IEnumerable<CourseType> GetCourses()
        {

            return _mockDataFaker.GenerateCourses(5);
        }

        public async Task<CourseType> GetCourseByIdAsync(Guid id)
        {
            await Task.Delay(1000);
            CourseType course = _mockDataFaker.GenerateCourse();

            return course;
        }

        // instead of versioning like in RestAPI
        [GraphQLDeprecated("This query is deprecated")]
        public string Instructions => "some random text";
    }
}
