using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.DataAccess.Dapper;
using TCCS.DataAccess.Interfaces;
using TCCS.DataAccess.Models;
using static Dapper.SqlMapper;

namespace TCCS.DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDapperRepository _dapper;
        public EmployeeRepository(IDapperRepository dapper)
        {
            _dapper = dapper;
        }

        public async Task<List<Employee>> GetListAsync()
        {
            var dbPara = new DynamicParameters();
            var res = await _dapper.GetAllAsync<Employee>("GetEmployeeList", dbPara);
            return res;
        }


        public async Task<Employee> GetByIdAsync(int id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", id, DbType.Int32);
            var res = await _dapper.GetAsync<Employee>("GetEmployeeById", dbPara);
            return res;
        }

        public async Task<int> AddAsync(Employee entity)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Name", entity.Name, DbType.String);
            dbPara.Add("Email", entity.EmailId, DbType.String);

            var res = await _dapper.ExecuteAsync("AddEmployee", dbPara);
            return res;
        }

        public async Task<int> UpdateAsync(Employee entity)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", entity.Id, DbType.Int32);
            dbPara.Add("Name", entity.Name, DbType.String);
            dbPara.Add("Email", entity.EmailId, DbType.String);

            var res = await _dapper.ExecuteAsync("UpdateEmployee", dbPara);
            return res;
        }

        public async Task<int> RemoveByIdAsync(int id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", id, DbType.Int32);
           

            var res = await _dapper.ExecuteAsync("DeleteEmployee", dbPara);
            return res;
        }

    }
}
