using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpticonBackend.Models;
using OpticonBackend.Data;

namespace OpticonBackend.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PictureController : ControllerBase
    {
        private readonly TopologiEditorContext _context;

        public PictureController(TopologiEditorContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, world!");
        }

        [HttpGet("{id}")]
        public ActionResult<Picture> Get(int id)
        {
            var picture = _context.Pictures.Include(r => r.Name).Include(r => r.Grid).FirstOrDefault(r => r.Id == id);

            if (picture == null)
            {
                return NotFound();
            }

            return picture;
        }

        [HttpGet("names")]
        public ActionResult<IEnumerable<string>> GetNames()
        {
            var pictureNames = _context.Pictures.Select(p => p.Name).ToList();

            if (!pictureNames.Any())
            {
                return NotFound();
            }

            return pictureNames;
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok($"Received: {value}");
        }
    }
}