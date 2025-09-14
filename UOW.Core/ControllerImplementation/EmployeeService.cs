using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;
using UOW.Infrastructure.RepositoryInterfaces;
using UOW.Services.ControllerInterfaces;
using UOW.Services.ControllerModels;

namespace UOW.Services.ControllerImplementation
{
    public class EmployeeService : IEmployeeService
    {
        IUnitOfWork _uow;
        public EmployeeService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<bool> Add(EmployeeDetail employee)
        {
            Employee emp = new Employee();
            emp.Id = employee.Id;
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.EmploymentTypeId = employee.EmploymentTypeId;
            emp.RoleId = employee.RoleId;
            emp.DepartmentId = employee.DepartmentId;

            await _uow._employeeRepository.Add(emp);
            var result = await _uow.Save();

            return result > 0 ? true : false;
        }

        public async Task<bool> Delete(Guid Id)
        {
            Employee emp = await _uow._employeeRepository.GetById(Id);
            if (emp != null)
            {
                _uow._employeeRepository.Delete(emp);
                var result = await _uow.Save();
                return result > 0 ? true : false;
            }
            return false;
        }

        public async Task<IEnumerable<EmployeeDetailResponse>> GetAll()
        {
            var result = await _uow._employeeRepository.GetAll();
            List<EmployeeDetailResponse> list = new List<EmployeeDetailResponse>();
            foreach (var emp in result)
            {
                list.Add(new EmployeeDetailResponse
                {
                    Id = emp.Id,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    DepartmentId = emp.DepartmentId,
                    RoleId = emp.RoleId,
                    EmploymentTypeId = emp.EmploymentTypeId,
                    Salary = emp.Salary,
                    Bonus = emp.BonusPercentage,
                    HouseAllowance = emp.HomeAllowance,
                    MedicalAllowance = emp.MedicalAllowance
                });
            }
            return list;
        }

        public async Task<EmployeeDetailResponse> GetById(Guid Id)
        {
            var result = await _uow._employeeRepository.GetById(Id);
            return new EmployeeDetailResponse
            {
                Id = result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                DepartmentId = result.DepartmentId,
                RoleId = result.RoleId,
                EmploymentTypeId = result.EmploymentTypeId,
                Salary = result.Salary,
                Bonus = result.BonusPercentage,
                HouseAllowance = result.HomeAllowance,
                MedicalAllowance = result.MedicalAllowance
            };
        }

        public async Task<bool> Update(EmployeeDetail employee)
        {
            var emp = await _uow._employeeRepository.GetById(employee.Id);
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.DepartmentId = employee.DepartmentId;
            emp.RoleId = employee.RoleId;
            emp.EmploymentTypeId = employee.EmploymentTypeId;

            _uow._employeeRepository.Update(emp);
            var result = await _uow.Save();
            return result > 0 ? true : false;

        }
    }
}
