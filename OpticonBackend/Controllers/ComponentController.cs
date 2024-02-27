using Microsoft.AspNetCore.Mvc;
using OpticonBackend.Models;
using OpticonBackend.Data;

namespace OpticonBackend.Controllers
{

    // add the [ApiController] attribute to the controller class
    [ApiController]
    [Route("api/[controller]")]

    public class ComponentController : Controller
    {
        private readonly TopologiEditorContext _context;

        public ComponentController(TopologiEditorContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SaveComponent([FromBody] OpticonBackend.Models.Component component)
        {

            _context.Components.Add(component);
            _context.SaveChanges();

            return Ok(component);
        }

        [HttpGet]
        public IActionResult GetComponents()
        {
            var components = _context.Components.ToList();
            return Ok(components);
        }

    }
}