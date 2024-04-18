using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampPlacesController : ControllerBase
    {
        ICapmPlaceService _capmPlaceService;
        public CampPlacesController(ICapmPlaceService campPlaceService)
        {
            _capmPlaceService = campPlaceService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _capmPlaceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _capmPlaceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
