using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class PutAPIController : ApiController
    {
        [HttpPut]
        public bool Update(dynamic obj)
        {
            return true;
        }

        [HttpPut]
        public object Update2(dynamic obj)
        {
            var strName = Convert.ToString(obj.name);
            return strName;
        }

        [HttpPut]
        public string Update3(Person person)
        {
            return String.Format("Update3?id={0}&name={1}&time={2}&sex={3}", person.id, person.name, person.time, person.sex);
        }
    }
}
