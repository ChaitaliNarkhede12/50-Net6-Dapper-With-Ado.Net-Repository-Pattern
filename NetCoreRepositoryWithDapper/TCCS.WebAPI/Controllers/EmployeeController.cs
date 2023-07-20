using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCCS.DataAccess.Interfaces;
using TCCS.DataAccess.Models;
using TCCS.WebAPI.ViewModel;

namespace TCCS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepository empRepo,
            IMapper mapper)
        {
            _empRepo = empRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync()
        {
            var res = await _empRepo.GetListAsync();
            return Ok(res);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var res = await _empRepo.GetByIdAsync(id);
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(EmployeeModel employeeModel)
        {
            var employee = _mapper.Map<Employee>(employeeModel);
            var res = await _empRepo.AddAsync(employee);
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(EmployeeModel employeeModel)
        {
            var employee = _mapper.Map<Employee>(employeeModel);
            var res = await _empRepo.UpdateAsync(employee);
            return Ok(res);
        }


        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var res = await _empRepo.RemoveByIdAsync(id);
            return Ok(res);
        }

    }
}
