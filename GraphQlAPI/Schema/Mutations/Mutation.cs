﻿using GraphQlAPI.Schema.Mutations;
using GraphQlAPI.Schema.Queries;

namespace GraphQlAPI.Schema.Queries.Mutations
{
    public class Mutation
    {
        private readonly List<CourseResult> _courses;

        public Mutation()
        {
            _courses = [];
        }

        public CourseResult CreatingCourse(CourseInputType courseInput)
        {
            CourseResult course = new CourseResult()
            {
                Id = Guid.NewGuid(),
                Name = courseInput.Name,
                Subject = courseInput.Subject,
                InstructorId = courseInput.InstructorId
            };
            _courses.Add(course);

            return course;
        }

        public CourseResult UpdateCourse(Guid id, CourseInputType courseInput)
        {
            CourseResult course = _courses.FirstOrDefault(c => c.Id == id);

            if (course is null)
            {
                throw new GraphQLException(new Error("Course not found", "COURSE_NOT_FOUND"));
            }

            course.Name = courseInput.Name;
            course.Subject = courseInput.Subject;
            course.InstructorId = courseInput.InstructorId;

            return course;
        }
        public List<CourseResult> GetAllCourses()
        {
            return _courses;
        }

        public bool DeleteCourse(Guid id)
        {
            return _courses.RemoveAll(c => c.Id == id) >= 1;
        }
    }
}
