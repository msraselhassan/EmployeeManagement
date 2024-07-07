using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.Interface
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartmentList();
        Department GetDepartmentById(int departmentId);
    }
}
