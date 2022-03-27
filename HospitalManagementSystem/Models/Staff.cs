using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Staff
    {
        //DoctorInChargeID in Patient will reference StaffID
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string Specialty { get; set; }

        //Using AspNetUsers properties such as Username, email & password
        public IdentityUser AspNetUsers { get; set; }
        [ForeignKey("AspNetUsers")]
        public string aspNetID { get; set; }
    }
}
