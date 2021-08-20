using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LampadaController : ControllerBase
    {
        static LampadaRepository repository = new LampadaRepository();
        // GET api/<LampadaController>
        [HttpGet]
        public List<Lampada> Get()
        {
            return repository.Read();
        }

        // GET api/<LampadaController>/5
        [HttpGet("{id}")]
        public Lampada Get(int id)
        {
            return repository.Read(id);
        }

        // POST api/<LampadaController>
        [HttpPost]
        public void Post([FromBody] Lampada model)
        {
            repository.Create(model);
        }

        // PUT api/<LampadaController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Lampada model)
        {
            repository.Update(model);
        }

        // DELETE api/<LampadaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
