using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Pattern
    {
        string Regex_Name = "^[A-Z][a-z]{2,}$";
        string Regex_email = "[a-zA-Z0-9]+([.+-_@#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        string Regex_MobNo = "^[1-9][0-9]\\s[1-9]{1}[0-9]{9}$";
        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, Regex_Name);
        }

        public bool ValidateEmail(string email)
        {

            return Regex.IsMatch(email, Regex_email);
        }

        public bool ValidateMobileNo(string MobNo) 
        {
            return Regex.IsMatch(MobNo, Regex_MobNo);
        }

    }
}
