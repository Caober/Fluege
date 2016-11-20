using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fluege.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Fluege.Controllers
{
    [Route("api/[controller]")]
    public class PassagierController : Controller
    {
        // GET: api/1
        [HttpGet("{id}")]
        public Passagier GetById(int id)
        {
            PassList pass = new PassList();
            return pass.GetPassagierById(id);
        }

       

        // POST api/List
        [HttpGet("List")]
        public List<Passagier> GetList()
        {
            PassList pass = new PassList();
            return pass.GetPassagierliste();
        }

        // GET api/?Vorname=Klaus&Nachname=Ekam
        [HttpGet("Passagier")]
        public Passagier GetByName(string vorname, string nachname)
        {
            PassList pass = new PassList();
            return pass.GetPassagier(vorname,nachname);

        }

        // Post api/
        [HttpPost]
        public void Post([FromBody] Passagier passagier)
        {
            PassList pass = new PassList();
            pass.AddPassagier(passagier);


        }
    }
}
