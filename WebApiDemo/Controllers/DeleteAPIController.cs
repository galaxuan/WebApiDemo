using System.Collections.Generic;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class DeleteAPIController : ApiController
    {
        [HttpDelete]
        public bool OptDelete(List<Person> lstChargin)
        {
            return true;
        }
    }
}
