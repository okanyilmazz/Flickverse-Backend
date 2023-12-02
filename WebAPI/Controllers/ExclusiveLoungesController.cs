using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExclusiveLoungesController : ControllerBase
    {
        IExclusiveLoungeService _exclusiveLoungeService;

        public ExclusiveLoungesController(IExclusiveLoungeService exclusiveLoungeService)
        {
            _exclusiveLoungeService = exclusiveLoungeService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _exclusiveLoungeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _exclusiveLoungeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(ExclusiveLounge exclusiveLounge)
        {
            var result = _exclusiveLoungeService.Add(exclusiveLounge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(ExclusiveLounge exclusiveLounge)
        {
            var result = _exclusiveLoungeService.Update(exclusiveLounge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(ExclusiveLounge exclusiveLounge)
        {
            var result = _exclusiveLoungeService.Delete(exclusiveLounge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
