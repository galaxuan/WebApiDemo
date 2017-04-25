using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class GetAPIController : ApiController
    {
        [HttpGet]
        public string Get(int id, string name, DateTime time)
        {
            return String.Format("Get?id={0}&name={1}&time={2}", id, name, time);
        }

        [HttpGet]
        public string GetModel([FromUri]Person person)
        {
            return String.Format("GetModel?id={0}&name={1}&time={2}&sex={3}", person.id, person.name, person.time, person.sex);
        }

        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}