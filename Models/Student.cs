using System.Collections.Generic;

namespace student_exercises
{
    public class Student{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slack { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }  = new List<Exercise>(); 
    }
}