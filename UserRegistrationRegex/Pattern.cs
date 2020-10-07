using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Pattern
    {
        string Regex_Name = "^[A-Z][a-z]{2,}$";

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, Regex_Name);
        }


    }
}
