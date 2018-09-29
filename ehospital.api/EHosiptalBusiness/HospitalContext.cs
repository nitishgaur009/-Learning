using EHosiptalBusiness.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHosiptalBusiness
{
    public class HospitalContext : DbContext
    {
        public HospitalContext():base("HospitalDB")
        {
        }

        public DbSet<Departments> Departments { get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<PatientHistory> PatientHistory { get; set; }

        public DbSet<Patients> Patients { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<UserLoginData> UserLoginData { get; set; }

        public DbSet<UserRoles> UserRoles { get; set; }
    }
}
