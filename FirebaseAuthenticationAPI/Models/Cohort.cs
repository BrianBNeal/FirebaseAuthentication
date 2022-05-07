namespace FirebaseAuthenticationAPI.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        public CohortType Type { get; set; }
        public int Number { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
    }

    public enum CohortType
    {
        DaytimeWebDev = 0,
        EveningWebDev = 1,
        DaytimeUIUX = 2,
        DaytimeDataAnalytics = 3,
        DaytimeDataScience = 4,
    }
}
