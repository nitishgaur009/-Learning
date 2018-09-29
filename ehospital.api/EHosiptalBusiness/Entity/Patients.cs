using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHosiptalBusiness.Entity
{
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int MobileNumber { get; set; }
    }
}
