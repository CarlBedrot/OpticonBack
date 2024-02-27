using Microsoft.AspNetCore.Mvc;
using OpticonBackend.Models;
using OpticonBackend.Data;

namespace OpticonBackend.Controllers
{

    // add the [ApiController] attribute to the controller class
    [ApiController]
    [Route("api/[controller]")]

    public class PictureController : Controller
    {
        private readonly TopologiEditorContext _context;

        public PictureController(TopologiEditorContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SavePicture([FromBody] OpticonBackend.Models.Picture picture)
        {

            _context.Pictures.Add(picture);
            _context.SaveChanges();

            return Ok(picture);
        }

        [HttpGet]
        public IActionResult GetPictures()
        {
            var pictures = _context.Pictures.ToList();
            return Ok(pictures);
        }
    }
}