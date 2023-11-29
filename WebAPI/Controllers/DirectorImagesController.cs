using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorImagesController : ControllerBase
    {

        IDirectorImageService _directorImageService;

        public DirectorImagesController(IDirectorImageService directorImageService)
        {
            _directorImageService = directorImageService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _directorImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _directorImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(DirectorImage directorImage)
        {
            var result = _directorImageService.Add(directorImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(DirectorImage directorImage)
        {
            var result = _directorImageService.Update(directorImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(DirectorImage directorImage)
        {
            var result = _directorImageService.Delete(directorImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
