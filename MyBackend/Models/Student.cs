﻿namespace MyBackend.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }

        public List<Course> Courses { get; set; }
        /*public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }*/
    }
}