using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_13
{
    class Validator
    {
        public string _letters { get; set; }
        public int _numbers { get; set; }
        public Validator()
        {
            
        }
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
        public static bool AreNumbersValid(int numbers)
        {
            if (Regex.IsMatch(numbers.ToString(), @"[0-9]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AreLettersValid(string letters)
        {
            if (Regex.IsMatch(letters, @"[A-z"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
