using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class IntermediateEnglishCertificate : EmployeeDecorator
    {
        public IntermediateEnglishCertificate(Employee employee) : base(employee.Name, employee.BaseSalary, employee)
        {
        }

        public string ExaminationTitle { get; set; }
        public int YearOfCertificate {  get; set; }
        public override string GetInfo()
        {
            string info = employee.GetInfo() + 
                "\n" + Separator.GetSeparator("-", 10) +
                "\nCertification: " + ExaminationTitle +
                "\nYear of certification: " + YearOfCertificate +
                "\n";
            return info;
        }
    }
}
