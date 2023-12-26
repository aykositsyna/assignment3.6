using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sberbank sberbank = new Sberbank();
            Gazprombank gazprombank = new Gazprombank();
            Employee e1 = new Engineer("Stanislav", 10000000000);
            e1.BankService = sberbank;

            Employee s1 = new Scientist("Marsha Mallow", 666);
            s1.BankService = gazprombank;
            s1 = new AcademicDegree(s1)
            {
                DissertationTitle = "Doctor of Science",
                DissertationYear = 2013,
                ScienceArea = "Numerology"
            };
            Console.WriteLine(Separator.GetSeparator("=", 10) +
                e1.GetInfo() + Separator.GetSeparator("=", 10) +
                s1.GetInfo() + Separator.GetSeparator("=", 10));
            Render();

            e1.BankService = gazprombank;
            e1 = new AcademicDegree(e1)
            {
                DissertationTitle = "Master",
                DissertationYear = 2010,
                ScienceArea = "Gastronomy"
            };


            s1 = new IntermediateEnglishCertificate(s1)
            {
                ExaminationTitle = "Duolingo Certificate",
                YearOfCertificate = 2019
            };

            Console.WriteLine(Separator.GetSeparator("=", 10) +
                 e1.GetInfo() + Separator.GetSeparator("=", 10) +
                 s1.GetInfo() + Separator.GetSeparator("=", 10));
            Render();





        }

        static private void Render()
        {
            Console.ReadKey();
            Console.Clear();
        }

    }
}
