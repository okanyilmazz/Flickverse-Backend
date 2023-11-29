using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCategoriesController : ControllerBase
    {
        IMovieCategoryService _movieCategoryService;

        public MovieCategoriesController(IMovieCategoryService movieCategoryService)
        {
            _movieCategoryService = movieCategoryService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _movieCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _movieCategoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(MovieCategory movieCategory)
        {
            var result = _movieCategoryService.Add(movieCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(MovieCategory movieCategory)
        {
            var result = _movieCategoryService.Update(movieCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(MovieCategory movieCategory)
        {
            var result = _movieCategoryService.Delete(movieCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
