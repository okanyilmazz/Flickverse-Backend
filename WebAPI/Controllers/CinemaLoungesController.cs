using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaLoungesController : ControllerBase
    {
        ICinemaLoungeService _cinemaLoungeService;

        public CinemaLoungesController(ICinemaLoungeService cinemaLoungeService)
        {
            _cinemaLoungeService = cinemaLoungeService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _cinemaLoungeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _cinemaLoungeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(CinemaLounge cinemaLoungeService)
        {
            var result = _cinemaLoungeService.Add(cinemaLoungeService);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(CinemaLounge cinemaLoungeService)
        {
            var result = _cinemaLoungeService.Update(cinemaLoungeService);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(CinemaLounge cinemaLoungeService)
        {
            var result = _cinemaLoungeService.Delete(cinemaLoungeService);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
