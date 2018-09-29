using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHosiptalBusiness.Entity
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
