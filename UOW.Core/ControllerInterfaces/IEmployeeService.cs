using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Services.ControllerModels;

namespace UOW.Services.ControllerInterfaces
{
    public interface IEmployeeService
    {
        Task<bool> Add(EmployeeDetail employee);
        Task<bool> Delete(Guid Id);
        Task<bool> Update(EmployeeDetail employee);
        Task<IEnumerable<EmployeeDetailResponse>> GetAll();
        Task<EmployeeDetailResponse> GetById(Guid Id);
    }
}
