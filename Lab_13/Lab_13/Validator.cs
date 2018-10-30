using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Validator
    {

        public bool Validation(string input)
        {
            if (input != "R" && input != "S" && input != "P")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
