namespace student_exercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slack { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }
        
        public void AddStudentExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }
    }
}