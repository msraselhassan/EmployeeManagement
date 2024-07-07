using EmployeeManagement.Models;
using EmployeeManagement.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentsRepository;
        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
                this._departmentsRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Department>> GetDepartments()
        {
            try
            {
                return Ok(await _departmentsRepository.GetDepartmentList());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                 "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            try
            {
                var result = await _departmentsRepository.GetDepartmentById(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error retrieving data from the database");
            }
        }
    }
}
