using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.DataAccess.Models;

namespace TCCS.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetListAsync();
        Task<Employee> GetByIdAsync(int id);
        Task<int> AddAsync(Employee entity);
        Task<int> UpdateAsync(Employee entity);
        Task<int> RemoveByIdAsync(int id);
    }
}
