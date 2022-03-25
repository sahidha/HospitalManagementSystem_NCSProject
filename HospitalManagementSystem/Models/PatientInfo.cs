using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class PatientInfo
    {
        [Key]
        public int PatientId { get; set; }

        public string PatientName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [DataType(DataType.DateTime)]
        public string DateOfIssue { get; set; }
    }
}
