namespace FirebaseAuthenticationAPI.Models
{
    public class Cohort
    {
        public string Id { get; set; }
        public CohortType Type { get; set; }
        public string LongName { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
    }

    public enum CohortType
    {
        DaytimeWebDev = 0,
        EveningWebDev = 1,
    }
}
