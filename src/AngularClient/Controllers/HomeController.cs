using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using PeopleReference.API.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: /<controller>/id
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            string url = "http://localhost:60167/api/people/" + id;
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(url);
            var person = JsonConvert.DeserializeObject<Person>(json);
            return View();
        }
    }
}
