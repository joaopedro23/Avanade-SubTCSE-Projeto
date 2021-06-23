using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(string firsName, 
            string surName, 
            DateTime birthday, 
            bool active, 
            decimal salary,
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            FirsName = firsName;
            SurName = surName;
            Birthday = birthday;
            Active = active;
            Salary = salary;
            this.employeeRole = employeeRole;
        }

        public string FirsName { get; init; }

        public string SurName { get; init; }

        public DateTime Birthday { get; init; }

        public bool Active { get; init; }

        public decimal Salary { get; init; }

        public EmployeeRole.Entities.EmployeeRole employeeRole { get; init; } 
    }
}
