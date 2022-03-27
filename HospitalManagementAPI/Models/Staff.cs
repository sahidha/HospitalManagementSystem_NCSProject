namespace HospitalManagementAPI.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public ApplicationUser User { get; set; }
    }
}
