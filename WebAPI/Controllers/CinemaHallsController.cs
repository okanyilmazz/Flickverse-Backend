using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaHallsController : ControllerBase
    {
        ICinemaHallService _cinemaHallService;

        public CinemaHallsController(ICinemaHallService cinemaHallService)
        {
            _cinemaHallService = cinemaHallService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _cinemaHallService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _cinemaHallService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetCinemaHallDetails")]
        public IActionResult GetCinemaHallDetails()
        {
            var result = _cinemaHallService.GetCinemaHallDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(CinemaHall cinemaHall)
        {
            var result = _cinemaHallService.Add(cinemaHall);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(CinemaHall cinemaHall)
        {
            var result = _cinemaHallService.Update(cinemaHall);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(CinemaHall cinemaHall)
        {
            var result = _cinemaHallService.Delete(cinemaHall);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
