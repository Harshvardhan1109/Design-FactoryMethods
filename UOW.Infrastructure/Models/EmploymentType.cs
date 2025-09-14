using System;
using System.Collections.Generic;

namespace UOW.Infrastructure.Models
{
    public partial class EmploymentType
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = null!;
    }
}
