﻿using GraphQlAPI.Schema.Queries;

namespace GraphQlAPI.Schema.Queries.Mutations
{
    public class CourseResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public Guid InstructorId { get; set; }
    }
}
