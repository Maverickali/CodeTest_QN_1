using CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTest.DataLayer
{
    public class SchoolDBInitializer
    {
        public static class DbInitializer
        {
            public static void Initialize(SchoolDBContext context)
            {
                context.Database.EnsureCreated();

                //Look for any students.
                if (context.Students.Any())
                    {
                        return;   // DB has been seeded
                    }

                var students = new Student[]
                {
                    new Student{StudentName="Carson Alexander",DateOfBirth=DateTime.Parse("2005-09-01"), Height=123, Weight=45},
                    new Student{StudentName="Meredith Alonso",DateOfBirth=DateTime.Parse("2002-09-01"), Height=123, Weight=15},
                    new Student{StudentName="Arturo Anand",DateOfBirth=DateTime.Parse("2003-09-01"), Height=123, Weight=40},
                    new Student{StudentName="Gytis Barzdukas",DateOfBirth=DateTime.Parse("2002-09-01"), Height=123, Weight=41},
                    new Student{StudentName="YanLi",DateOfBirth=DateTime.Parse("2002-09-01"), Height=123, Weight=42},
                    new Student{StudentName="Peggy Justice",DateOfBirth=DateTime.Parse("2001-09-01"), Height=123, Weight=45},
                    new Student{StudentName="Laura Norman",DateOfBirth=DateTime.Parse("2003-09-01"), Height=123, Weight=45},
                    new Student{StudentName="Nino Olivetto",DateOfBirth=DateTime.Parse("2005-09-01"), Height=123, Weight=45}
                };
                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();



                var courses = new Course[]
                    {
                    new Course{CourseID=1050,Title="Chemistry",Credits=3},
                    new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                    new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                    new Course{CourseID=1045,Title="Calculus",Credits=4},
                    new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                    new Course{CourseID=2021,Title="Composition",Credits=3},
                    new Course{CourseID=2042,Title="Literature",Credits=4}
                    };
                foreach (Course c in courses)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();

            }
        }
    }
}
