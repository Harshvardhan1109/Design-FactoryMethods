using System;
using System.Collections.Generic;

namespace UOW.Infrastructure.Models
{
    public partial class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public decimal Salary { get; set; }
        public Guid RoleId { get; set; }
        public Guid DepartmentId { get; set; }
        public decimal BonusPercentage { get; set; }
        public decimal HomeAllowance { get; set; }
        public decimal MedicalAllowance { get; set; }
        public Guid EmploymentTypeId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
