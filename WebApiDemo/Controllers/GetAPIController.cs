using Newtonsoft.Json;
using System;
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
        public string GetAllChargingData([FromUri]Person person)
        {
            return String.Format("GetAllChargingData?id={0}&name={1}&time={2}&sex={3}", person.id, person.name, person.time, person.sex);
        }

        [HttpGet]
        public string GetByModel(string strQuery)
        {
            Person person = JsonConvert.DeserializeObject<Person>(strQuery);
            return String.Format("GetByModel?id={0}&name={1}&time={2}&sex={3}", person.id, person.name, person.time, person.sex);
        }
    }
}