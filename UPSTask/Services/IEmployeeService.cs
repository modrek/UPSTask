using System.Threading.Tasks;
using UPSTask.Models;

namespace UPSTask.Services
{
    public interface IEmployeeService
    {
        object DataGridViewItems { get; set; }
        Task AddEmployeeAsync();
        Task DeleteEmployeeAsync();
        Task<EmployeeModel> GetEmployeeAsync();
        Task GetEmployeeListAsync(int? page);
        Task SearchEmployeeAsync();
        Task UpdateEmployeeAsync();
    }
}