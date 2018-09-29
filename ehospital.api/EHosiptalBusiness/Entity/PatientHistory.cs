using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHosiptalBusiness.Entity
{
    public class PatientHistory
    {
        [Key]
        public int PatientHistoryId { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Diagnosis { get; set; }

        [ForeignKey("PatientId")]
        public Patients Patient { get; set; }

        [ForeignKey("DoctorId")]
        public Doctors Doctor { get; set; }
    }
}
