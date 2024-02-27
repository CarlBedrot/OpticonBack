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

    public class PictureAccessController : Controller
    {
        private readonly TopologiEditorContext _context;

        public PictureAccessController(TopologiEditorContext context)
        {
            _context = context;
        }
       
        [HttpPost]
        public async Task<ActionResult<PictureAccess>> CreatePictureAccess(PictureAccess pictureAccess)
        {
            if (pictureAccess == null)
            {
                return BadRequest("Invalid picture access data");
            }

            _context.PictureAccesses.Add(pictureAccess);
            await _context.SaveChangesAsync();

            // Assuming 'UserId' is the key and used to access the newly created PictureAccess
            return CreatedAtAction(nameof(CreatePictureAccess), new { userId = pictureAccess.UserId }, pictureAccess);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PictureAccess>>> GetPictureAccesses()
        {
            return await _context.PictureAccesses.ToListAsync();
        }

    }
}