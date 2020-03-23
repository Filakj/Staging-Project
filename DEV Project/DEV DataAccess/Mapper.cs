using System;
using System.Collections.Generic;
using System.Text;
using DEV_Library; 



namespace DEV_DataAccess
{
    public class Mapper
    {

        public DEV_Library.Models.Student MapStudent(Entities.Student student)
        {
            return new DEV_Library.Models.Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Email = student.Email,
                Username = student.Username
            };

        }
        public Entities.Student MapStudent(DEV_Library.Models.Student student)
        {
            return new Entities.Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Email = student.Email,
                Username = student.Username
            };
        }
        public DEV_Library.Models.Instructor  MapInstructor(Entities.Instructor instructor)
        {
            return new DEV_Library.Models.Instructor
            {
                Id = instructor.Id,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                Email = instructor.Email,
                Username = instructor.Username
            };
        }

        public Entities.Instructor MapInstructor(DEV_Library.Models.Instructor instructor)
        {
            return new Entities.Instructor
            {
                Id = instructor.Id,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                Email = instructor.Email,
                Username = instructor.Username
            };
        }

        public DEV_Library.Models.Course MapCourse(Entities.Course course)
        {
            return new DEV_Library.Models.Course
            {
                Id = course.Id,
                CourseName = course.CourseName,
                InstructorId = (System.Guid)course.InstructorId,
                SectionNumber = course.SectionNumber
            };
        }

        public Entities.Course MapCourse(DEV_Library.Models.Course course)
        {
            return new Entities.Course
            {
                Id = course.Id,
                CourseName = course.CourseName,
                InstructorId = (System.Guid)course.InstructorId,
                SectionNumber = course.SectionNumber
            };

        }

        public DEV_Library.Models.Registration MapRegistration(Entities.Registration registration)
        {
            return new DEV_Library.Models.Registration
            {
                Id = registration.Id,
                CourseId = (System.Guid)registration.CourseId,
                StudentId = (System.Guid)registration.StudentId
            };
        }

        public Entities.Registration MapRegistration(DEV_Library.Models.Registration registration)
        {
            return new Entities.Registration
            {
                Id = registration.Id,
                CourseId = (System.Guid)registration.CourseId,
                StudentId = (System.Guid)registration.StudentId
            };
        }

        public DEV_Library.Models.Task MapTask(Entities.Task task)
        {
            return new DEV_Library.Models.Task
            {
                Id = task.Id,
                CourseId = (System.Guid)task.CourseId,
                TaskName = task.TaskName,
                TaskDescription = task.TaskDescription,
                DueDate = (System.DateTime)task.DueDate
            };
        }

        public Entities.Task MapTask(DEV_Library.Models.Task task)
        {
            return new Entities.Task
            {
                Id = task.Id,
                CourseId = (System.Guid)task.CourseId,
                TaskName = task.TaskName,
                TaskDescription = task.TaskDescription,
                DueDate = (System.DateTime)task.DueDate
            };
        }



    }
}
