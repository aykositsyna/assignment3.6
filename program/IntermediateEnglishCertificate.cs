using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class IntermediateEnglishCertificate : EmployeeDecorator
    {
        public IntermediateEnglishCertificate(string name, double salary, Employee employee) : base(name, salary, employee)
        {
        }

        public string ExaminationTitle { get; set; }
        public int YearOfCertificate {  get; set; }
        public override string GetInfo()
        {
            string info = base.GetInfo() + "\nCertification: " + ExaminationTitle + "\nYear of certification: " + YearOfCertificate;
            return info;
        }
    }
}
