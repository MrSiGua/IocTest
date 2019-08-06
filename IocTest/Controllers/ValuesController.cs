using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IocTest.Models;

namespace IocTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ISingTest sing; ITranTest tran; ISconTest scon; IAService aService;

        public ValuesController(ISingTest sing, ITranTest tran, ISconTest scon, IAService aService)
        {
            this.sing = sing;
            this.tran = tran;
            this.scon = scon;
            this.aService = aService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> SetTest()
        {
            sing.Age = 18;
            sing.Name = "小红";

            tran.Age = 19;
            tran.Name = "小明";

            scon.Age = 20;
            scon.Name = "小蓝";

            aService.RedisTest();


            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
