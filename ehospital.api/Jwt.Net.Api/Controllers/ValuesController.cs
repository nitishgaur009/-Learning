using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jwt.Net.Api.Controllers
{
    public class ValuesController : ApiController
    {
        [Authorize()]
        public IHttpActionResult Get()
        {
            IEnumerable<string> values = new List<string>
            {
                "Value1",
                "Value2"
            };

            return Ok(values);
        }
    }
}
