using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.Interface
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartmentList();
        Task<Department> GetDepartmentById(int departmentId);
    }
}
