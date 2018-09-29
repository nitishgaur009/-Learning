using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jwt.Net.Api.Models
{
    public class UserData
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}