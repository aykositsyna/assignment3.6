using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    abstract class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public IBankService BankService { get; set; }

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.BaseSalary = salary;
        }

        public virtual string GetInfo()
        {
            string result = "Name: " + Name + "\n" +
                "Salary: " + BaseSalary + "\n" +
                "Bank: " + BankService + "\n" +
                "Salary after banking service: " + CalculateSalary(BaseSalary) + "\n";
            return result;
        }

        private double CalculateSalary(double salary)
        {
            return BankService.CalculateSalary(BaseSalary);
        }
    }
}
