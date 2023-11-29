using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieDirectorsController : ControllerBase
    {

        IMovieDirectorService _movieDirectorService;

        public MovieDirectorsController(IMovieDirectorService movieDirectorService)
        {
            _movieDirectorService = movieDirectorService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _movieDirectorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _movieDirectorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(MovieDirector movieDirector)
        {
            var result = _movieDirectorService.Add(movieDirector);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(MovieDirector movieDirector)
        {
            var result = _movieDirectorService.Update(movieDirector);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(MovieDirector movieDirector)
        {
            var result = _movieDirectorService.Delete(movieDirector);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
