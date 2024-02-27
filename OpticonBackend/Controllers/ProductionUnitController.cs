using Microsoft.AspNetCore.Mvc;
using OpticonBackend.Data;
using OpticonBackend.Models;
using System.Threading.Tasks;

namespace OpticonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionUnitsController : ControllerBase
    {
        private readonly TopologiEditorContext _context;

        public ProductionUnitsController(TopologiEditorContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ProductionUnit>> PostProductionUnit(ProductionUnit productionUnit)
        {
            _context.ProductionUnits.Add(productionUnit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductionUnit", new { id = productionUnit.Id }, productionUnit);
        }

        // GET: api/ProductionUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductionUnit>> GetProductionUnit(int id)
        {
            var productionUnit = await _context.ProductionUnits.FindAsync(id);

            if (productionUnit == null)
            {
                return NotFound();
            }

            return productionUnit;
        }

        // Additional methods (PUT, DELETE, etc.) can be added here as needed.
    }
}
