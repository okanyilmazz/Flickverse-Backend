using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieImagesController : ControllerBase
    {
        IMovieImageService _movieImageService;

        public MovieImagesController(IMovieImageService movieImageService)
        {
            _movieImageService = movieImageService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _movieImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _movieImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(MovieImage movieImage)
        {
            var result = _movieImageService.Add(movieImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(MovieImage movieImage)
        {
            var result = _movieImageService.Update(movieImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(MovieImage movieImage)
        {
            var result = _movieImageService.Delete(movieImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
