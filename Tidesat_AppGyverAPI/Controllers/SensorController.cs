using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tidesat_AppGyverAPI.Controllers
{
    [Route("api/[controller]")]
    public class SensorController : Controller
    {
        List<Sensor> sensores = new();

        public SensorController()
        {
            sensores.Add(new Sensor(1, "Sensor Tide1", "teste_codigo", "teste", "-30047980", "-51225563", true));
            sensores.Add(new Sensor(2, "Sensor Tide2", "teste_codigo", "teste", "-30047980", "-51225563", true));
            sensores.Add(new Sensor(3, "Sensor Tide3", "teste_codigo", "teste", "-30047980", "-51225563", true));
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Sensor> Get()
        {

            return sensores;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Sensor Get(int id)
        {
            return sensores.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

