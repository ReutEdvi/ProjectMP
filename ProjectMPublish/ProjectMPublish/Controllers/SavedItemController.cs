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
using System.Data;

namespace ProjectMPublish.Controllers
{
    public class SavedItemController : ApiController
    {
        public DataTable Get()
        {
            DBServicesS ds = new DBServicesS();
            string query = "SELECT * FROM SavedItems_2021";
            return ds.Select(query);
        }
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] RowEdit value)
        {
            string q = "UPDATE SavedItems_2021 SET description='" + value.description + "', Title='" + value.title + "' WHERE id=" + id;
            DBServicesS ds = new DBServicesS();
            ds.Update(q);
        }
        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            string q = "DELETE FROM SavedItems_2021 WHERE Id=" + id;
            DBServicesS ds = new DBServicesS();
            ds.Update(q);
        }
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
        }

        // PUT api/<controller>/5
        

        // DELETE api/<controller>/5
        
    }
}