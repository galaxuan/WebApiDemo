using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class PostAPIController : ApiController
    {
        //[HttpPost]
        //public string SaveData([FromBody]string name)
        //{
        //    return name;
        //}

        [HttpPost]
        public object SaveData2(dynamic obj)
        {
            var strName = Convert.ToString(obj.name);
            return strName;
        }

    }
}