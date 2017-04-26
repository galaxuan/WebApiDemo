using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class PostAPIController : ApiController
    {
        //[HttpPost]
        //public string SaveData([FromBody]string name)
        //{
        //    return name;
        //}

        //[HttpPost]
        //public object SaveData2(dynamic obj)
        //{
        //    var strName = Convert.ToString(obj.name);
        //    return strName;
        //}

        //[HttpPost]
        //public string SaveData3(Person person)
        //{
        //    return String.Format("SaveData3?id={0}&name={1}&time={2}&sex={3}", person.id, person.name, person.time, person.sex);
        //}

        [HttpPost]
        public string SaveData4(dynamic obj)
        {
            var strName = Convert.ToString(obj.name);
            var person = JsonConvert.DeserializeObject<Person>(Convert.ToString(obj.Charging));
            return String.Format("SaveData4?id={0}&name={1}&time={2}&sex={3}", person.id, person.name, person.time, person.sex);
        }

    }
}