using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Staff
    {
        //DoctorInChargeID in Patient will reference StaffID
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public string aspNetID { get; set; }

    }
}
