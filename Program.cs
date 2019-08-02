using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise UrbanPlanner = new Exercise()
            {
                Name = "Urban Planner",
                Language = "CSharp"
            };

            Exercise UrbanPlanner2 = new Exercise()
            {
                Name = "Urban Planner 2",
                Language = "CSharp"
            };

            Exercise CityBuilder = new Exercise()
            {
                Name = "City Builder",
                Language = "Node.JS"
            };

            Exercise EmployeeList = new Exercise()
            {
                Name = "Employee List",
                Language = "JavaScript"
            };

            Cohort Cohort32 = new Cohort()
            {
                Name = "Day Cohort 32"
            };

            Cohort Cohort33 = new Cohort()
            {
                Name = "Day Cohort 33"
            };

            Cohort Cohort31 = new Cohort()
            {
                Name = "Day Cohort 31"
            };

            Student Logan = new Student()
            {
                FirstName = "Logan",
                LastName = "Pablo",
                Slack = "YungMan",
                Cohort = Cohort31,
            };

            Student Joe = new Student()
            {
                FirstName = "Joe",
                LastName = "Pedro",
                Slack = "OldMan",
                Cohort = Cohort32
            };

            Student Perry = new Student()
            {
                FirstName = "Perry",
                LastName = "Pete",
                Slack = "OlderMan",
                Cohort = Cohort33
            };

            Student Pike = new Student()
            {
                FirstName = "Pike",
                LastName = "Pikemen",
                Slack = "YungMan",
                Cohort = Cohort32
            };

            Instructor Adam = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Sandman",
                Slack = "LilTay",
                Cohort = Cohort31,
                Specialty = "The Rap Game"
            };
            Instructor Jordan = new Instructor()
            {
                FirstName = "Jordan",
                LastName = "Jones",
                Slack = "UberDriver",
                Cohort = Cohort33,
                Specialty = "Cake"
            };
            Instructor Alan = new Instructor()
            {
                FirstName = "Alan",
                LastName = "Broseph",
                Slack = "BroTein",
                Cohort = Cohort33,
                Specialty = "Gym"
            };


            Alan.AddStudentExercise(UrbanPlanner, Logan);
            Alan.AddStudentExercise(UrbanPlanner2, Logan);
            Alan.AddStudentExercise(CityBuilder, Logan);

            Jordan.AddStudentExercise(CityBuilder, Joe);
            Jordan.AddStudentExercise(EmployeeList, Joe);

            Adam.AddStudentExercise(UrbanPlanner, Perry);
            Adam.AddStudentExercise(UrbanPlanner2, Perry);

            Adam.AddStudentExercise(CityBuilder, Pike);
            Adam.AddStudentExercise(EmployeeList, Pike);

            List<Student> students = new List<Student>()
            {
                Logan,
                Joe,
                Perry,
                Pike
            };

            // List<Exercise> exercises = new List<Exercise>()
            // {
            //     UrbanPlanner,
            //     UrbanPlanner2,
            //     CityBuilder,
            //     EmployeeList
            // };

            foreach (Student student in students)
            {
                System.Console.WriteLine($"{student.FirstName + " " + student.LastName} - {student.Exercises.Count} Exercises");
                System.Console.WriteLine("--------------------------");

                foreach (Exercise exercise in student.Exercises)
                {
                    System.Console.WriteLine(exercise.Name);
                }
                System.Console.WriteLine();
            }
        }
    }
}
