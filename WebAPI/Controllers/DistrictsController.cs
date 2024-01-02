﻿using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        IDistrictService _districtService;

        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _districtService.GetListAsync();
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _districtService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CreateDistrictRequest createDistrictRequest)
        {
            var result = await _districtService.AddAsync(createDistrictRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(UpdateDistrictRequest updateDistrictRequest)
        {
            var result = await _districtService.UpdateAsync(updateDistrictRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(DeleteDistrictRequest deleteDistrictRequest)
        {
            var result = await _districtService.DeleteAsync(deleteDistrictRequest);
            return Ok(result);
        }
    }
}