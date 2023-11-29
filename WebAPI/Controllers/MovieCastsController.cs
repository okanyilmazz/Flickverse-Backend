using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCastsController : ControllerBase
    {

        IMovieCastService _movieCastService;

        public MovieCastsController(IMovieCastService movieCastService)
        {
            _movieCastService = movieCastService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _movieCastService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _movieCastService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(MovieCast movieCast)
        {
            var result = _movieCastService.Add(movieCast);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(MovieCast movieCast)
        {
            var result = _movieCastService.Update(movieCast);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(MovieCast movieCast)
        {
            var result = _movieCastService.Delete(movieCast);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
