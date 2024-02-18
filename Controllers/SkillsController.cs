using Microsoft.AspNetCore.Mvc;
using w3schools.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace w3schools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {       
        // GET: api/<SkillsController>
        [HttpGet]
        public IEnumerable<Skill> Get()
        {
            Managers.SkillManager sm = new Managers.SkillManager();
            return sm.GetData();
        }        

        // GET api/<SkillsController>/5
        [HttpGet("{id}")]
        public Models.Skill Get(int id)
        {
            Managers.SkillManager sm = new Managers.SkillManager();
            return sm.GetById(id);
        }

        // POST api/<SkillsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SkillsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SkillsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
