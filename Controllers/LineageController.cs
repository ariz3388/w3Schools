using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using w3schools.Managers;
using w3schools.Models;

namespace w3schools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineageController : ControllerBase
    {
        private IManager<Lineage> lineageManager;

        public LineageController()
        {
            var temp = new LineageManager();
            lineageManager = temp as IManager<Lineage>;
        }

        [HttpGet]
        public IEnumerable<Lineage> Get()
        {
            return lineageManager.GetData();
        }

        [HttpGet]
        public Lineage GetLineage(int id)
        {
            return lineageManager.GetById(id);
        }
    }
}
