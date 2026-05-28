using EmployeeManagement.DAL.Model.DTOs;
using EmployeeManagement.DAL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployees([FromQuery] int? id)
        {
            var x = await _service.GetEmployee(id);
            return Ok(x);
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeDTO dto)
        {
            await _service.CreateEmployee(dto);
            return Ok(dto);
        }

        [HttpPut]
        public async Task<ActionResult> Update(EmployeeDTO dto)
        {
            await _service.UpdateEmployee(dto);
            return Ok("Employee Updated");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteEmployee(id);
            return Ok("Employee Deleted");
        }
    }
}
