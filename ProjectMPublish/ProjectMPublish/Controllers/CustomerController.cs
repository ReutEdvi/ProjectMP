using ProjectMPublish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectMPublish.Controllers
{
    public class CustomerController : ApiController
    {
        // GET api/<controller>
        public Customer Get(string email, string password)
        {
            Customer c = new Customer();
            return c.Read(email, password);

        }
        // POST api/<controller>
        public void Post([FromBody] Customer cr)
        {
            cr.InsertC();
            //return businesses;
        }
        //public void Post(string email, List<Highlights> highlights)
        //{
        //    Customer c = new Customer();
        //    c.SaveHighlightCustomer(email, highlights);
        //    //return businesses;
        //}



        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}