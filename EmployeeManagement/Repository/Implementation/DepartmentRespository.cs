using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository.Implementation
{
    public class DepartmentRespository:IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRespository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return await _appDbContext.Departments.FirstOrDefaultAsync(d=>d.DepartmentId == departmentId);
        }

        public async Task<IEnumerable<Department>> GetDepartmentList()
        {
            return await _appDbContext.Departments.ToListAsync();
        }
    }
}
