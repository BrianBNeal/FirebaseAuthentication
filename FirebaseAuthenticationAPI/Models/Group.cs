namespace FirebaseAuthenticationAPI.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CohortId { get; set; }
        public Cohort Cohort { get; set; }
        public List<Student> Members { get; set; }
        public Instructor Mentor { get; set; }
    }
}
