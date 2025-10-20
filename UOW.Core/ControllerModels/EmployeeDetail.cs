using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOW.Services.ControllerModels
{
    public class EmployeeDetail
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Guid EmploymentTypeId { get; set; }
        public Guid RoleId { get; set; }
        public Guid DepartmentId { get; set; }
    }

    public class EmployeeDetailResponse : EmployeeDetail
    {
        public Decimal? HouseAllowance { get; set; }
        public Decimal? MedicalAllowance { get; set; }
        public Decimal Salary { get; set; }
        public Decimal Bonus { get; set; }
        public String? SystemDetails { get; set; }
        public String? ExtaAssets { get; set; }
    }
}
