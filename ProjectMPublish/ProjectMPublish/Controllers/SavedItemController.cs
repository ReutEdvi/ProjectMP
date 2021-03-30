using ProjectMPublish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;
using System.IO;

namespace ProjectMPublish.Controllers
{
    public class SavedItemController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        //[Route("api/SavedItem")]
        //[Route("")]
        [HttpPost]
        [Route("api/SavedItem")]
        public void Post([FromBody] SavedItem sv)
        {
             sv.InsertSave();

            //rerutn mmmmm
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}