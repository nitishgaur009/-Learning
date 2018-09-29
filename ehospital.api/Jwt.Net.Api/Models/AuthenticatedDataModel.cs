using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jwt.Net.Api.Models
{
    public class AuthenticatedDataModel
    {
        public AuthenticatedDataModel()
        {
            roles = new List<string>();
        }

        public string username { get; set; }

        public List<string> roles { get; set; }

        public string token { get; set; }

        public bool isAuthenticated { get; set; }
    }
}