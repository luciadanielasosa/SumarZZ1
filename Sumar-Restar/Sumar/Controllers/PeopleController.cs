using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public Person Listar()
        {
            Person person = new Person()
            {
                PersonId = 1,
                Name = "Lucia Sosa"
            };
            return person;
        }
    }

    internal class Person
    {
        public Person()
        {
        }

        public int PersonId { get; set; }
        public string Name { get; set; }
    }
}
