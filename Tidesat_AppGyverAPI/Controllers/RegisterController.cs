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

    public class RegisterController : Controller
    {
        List<Register> registers = new();

        public RegisterController() {
            registers = new List<Register>();
            registers.Add(new Register(1, 1, 8667, Convert.ToDateTime("10-01-2022")));
            registers.Add(new Register(2, 1, 8660, Convert.ToDateTime("10-02-2022")));
            registers.Add(new Register(3, 1, 8666, Convert.ToDateTime("10-03-2022")));
            registers.Add(new Register(4, 1, 8662, Convert.ToDateTime("10-04-2022")));
            registers.Add(new Register(5, 1, 8657, Convert.ToDateTime("10-05-2022")));
            registers.Add(new Register(6, 1, 8688, Convert.ToDateTime("10-06-2022")));
            registers.Add(new Register(7, 1, 8678, Convert.ToDateTime("10-07-2022")));
                   registers.Add(new Register(8, 1, 8660, Convert.ToDateTime("10-08-2022")));
                    registers.Add(new Register(9, 1, 8632, Convert.ToDateTime("10-09-2022")));
                    registers.Add(new Register(10, 1, 8623, Convert.ToDateTime("10-10-2022")));
                    registers.Add(new Register(11, 1, 8612, Convert.ToDateTime("10-11-2022")));
                    registers.Add(new Register(12, 1, 8627, Convert.ToDateTime("10-12-2022")));

                    registers.Add(new Register(13, 1, 8627, Convert.ToDateTime("10-01-2023")));
                    registers.Add(new Register(14, 1, 8629, Convert.ToDateTime("10-02-2023")));
                    registers.Add(new Register(15, 1, 8628, Convert.ToDateTime("10-03-2023")));
                    registers.Add(new Register(16, 1, 8627, Convert.ToDateTime("10-04-2023")));
                    registers.Add(new Register(17, 1, 8637, Convert.ToDateTime("10-05-2023")));
                    registers.Add(new Register(18, 1, 8635, Convert.ToDateTime("10-06-2023")));
                    registers.Add(new Register(19, 1, 8634, Convert.ToDateTime("10-07-2023")));
                    registers.Add(new Register(20, 1, 8633, Convert.ToDateTime("10-08-2023")));
                    registers.Add(new Register(21, 1, 8666, Convert.ToDateTime("10-09-2023")));
                    registers.Add(new Register(22, 1, 8689, Convert.ToDateTime("10-10-2023")));
                    registers.Add(new Register(23, 1, 8695, Convert.ToDateTime("10-11-2023")));
                    registers.Add(new Register(24, 1, 8720, Convert.ToDateTime("10-12-2023")));
        


        }
        // GET: api/values
        [HttpGet]
        [EnableCors]

        public IEnumerable<Register> Get()
        {
            return registers;
        }

        // GET api/values/5
        [HttpGet("{idSensor}")]
        public IEnumerable<Register> GetbySensor(string idSensor)
        {
            int idsensor = Convert.ToInt32(idSensor);
            return registers.Where(x => x.IdSensor == idsensor).ToList();
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

