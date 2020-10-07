using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Pattern
    {
        string Regex_fName = "^[A-Z][a-z]{2,}$";

        public bool ValidateFname(string fname)
        {
            return Regex.IsMatch(fname, Regex_fName);
        }


    }
}
