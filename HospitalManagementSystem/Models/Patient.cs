using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string Description { get; set;} = string.Empty;
        [DataType(DataType.Date)]
        public string DateOfIssue { get; set; } = string.Empty;
        public int DoctorInChargeId { get; set; } = 0;
    }
}
