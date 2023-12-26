using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class EmployeeDecorator : Employee
    {
        protected Employee employee;
        public EmployeeDecorator(string name, double salary, Employee employee) : base(name, salary)
        {
            this.employee = employee;
        }
    }
}
