namespace AgendaTelefonica.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int PeopleID { get; set; }

        public virtual People People { get; set; }
    }
}