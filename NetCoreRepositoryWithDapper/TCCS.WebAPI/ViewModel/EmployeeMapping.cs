using AutoMapper;
using TCCS.DataAccess.Models;

namespace TCCS.WebAPI.ViewModel
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping()
        {
            CreateMap<EmployeeModel, Employee>();
            CreateMap<Employee, EmployeeModel>();
        }
    }
}
