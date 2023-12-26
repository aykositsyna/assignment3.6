using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Separator
    {

        static public string GetSeparator(string symbol, int number)
        {
            string separator = symbol;
            for (int i = 0; i < number - 1; i++)
            {
                separator += symbol;
            }
            separator += '\n';
            return separator;
        }
    }
}
