using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class Post2APIController : ApiController
    {
        //[HttpPost]
        //public bool SaveData(string[] ids)
        //{
        //    return true;
        //}

        [HttpPost]
        public bool SaveData2(List<Person> list)
        {
            return true;
        }
    }
}
