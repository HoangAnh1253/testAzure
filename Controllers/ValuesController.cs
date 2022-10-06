using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace devops_api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private List<string> listValues = new List<string>(){"anh", "em"};
        
        [HttpGet]
        public ActionResult<List<string>> Get(){
            return Ok(listValues);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id){
            return listValues[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] string value){
            listValues.Add(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromQuery] int id, [FromBody] string value){
            listValues[id] = value;
            return Ok(listValues[id]);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromQuery] int id) {
            string value = listValues[id];
            listValues.RemoveAt(id);
            return Ok(value);
        }
    }
}