using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PeopleReference.API.Models;

namespace PeopleReference.API.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        
            Datamanager dm = new Datamanager();
        // GET: api/people
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return dm.GetAllPeople();
        }

        // GET api/people/5
        [HttpGet("{id}")]
        public Person GetById(int id)
        {
            return dm.GetById(id);
        }

        //// POST api/people
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
