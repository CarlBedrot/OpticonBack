using Microsoft.AspNetCore.Mvc;
using OpticonBackend.Models;
using OpticonBackend.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OpticonBackend.Controllers
{

    // add the [ApiController] attribute to the controller class
    [ApiController]
    [Route("api/[controller]")]

    public class ComponentTypeController : Controller
    {
        private readonly TopologiEditorContext _context;

        public ComponentTypeController(TopologiEditorContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<ComponentType>> CreateComponentType(ComponentType componentType)
        {
            if (componentType == null)
            {
                return BadRequest("Invalid component type data");
            }

            _context.ComponentTypes.Add(componentType);
            await _context.SaveChangesAsync();

            // Assuming 'Name' is the key and used to access the newly created ComponentType
            return CreatedAtAction(nameof(CreateComponentType), new { name = componentType.Name }, componentType);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComponentType>>> GetComponentTypes()
        {
            return await _context.ComponentTypes.ToListAsync();
        }
    }
}