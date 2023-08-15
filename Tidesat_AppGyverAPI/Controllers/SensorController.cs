using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tidesat_AppGyverAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    public class SensorController : Controller
    {
        List<Sensor> sensores = new();

        public SensorController()
        {
            sensores.Add(new Sensor(1, "TIDESAT_ARR_DILUV", "TIDE_0942", "Monitoramento das águas do arroio Dilúvio prox ao Guaíba", true, new Location(-30.047980, -51.225563)));
            sensores.Add(new Sensor(2, "Sensor Tide2", "teste_codigo", "teste", true, new Location(-30.047980, -51.225563)));
            sensores.Add(new Sensor(3, "Sensor Tide3", "teste_codigo", "teste", false, new Location(-30.047980, -51.225563)));
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

