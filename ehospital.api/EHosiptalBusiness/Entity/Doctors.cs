using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHosiptalBusiness.Entity
{
    public class Doctors
    {
        [Key]
        public int DoctorId { get; set; }

        public string Name { get; set; }

        public string Qualification { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Departments Department { get; set; }
    }
}
