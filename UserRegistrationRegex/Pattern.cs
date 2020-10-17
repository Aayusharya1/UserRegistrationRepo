using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Pattern
    {
        string Regex_Name = "^[A-Z][a-z]{2,}$";
        string Regex_email = "[a-zA-Z0-9]+([.+-_@#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        string Regex_MobNo = "^[1-9][0-9]\\s[1-9]{1}[0-9]{9}$";
        string Regex_Password = "((?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[@$#^!-+][a-zA-Z0-9]*$)).{8,}";
        public bool ValidateName(string name)
        {
            if (Regex.IsMatch(name, Regex_Name)) return true;
            else 
            {
                string message = "name should contain atleast 3 characters and first letter should be in UpperCase";
                throw new UserRegistrationException(UserRegistrationException.InvalidationType.INVALID_FIRST_NAME, message);
            }
        }

        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, Regex_email)) return true;
            else 
            {
                string message = "Email id should be in \" abc.xyz@bl.co.in \" format (.xyz & .in parts optional)";
                throw new UserRegistrationException(UserRegistrationException.InvalidationType.INVALID_EMAIL, message);
            }
        }

        public bool ValidateMobileNo(string MobNo) 
        {
            if (Regex.IsMatch(MobNo, Regex_MobNo)) return true;
            else
            {
                string message = "Phone number should have 2 digit country code followed by space separated 10 digit number";
                throw new UserRegistrationException(UserRegistrationException.InvalidationType.INVALID_PHONE_NUMBER, message);

            }
        }

        public bool ValidatePassword(string password) 
        {
            if(Regex.IsMatch(password, Regex_Password)) return true;

            else
            {
                string message = "Password needs to have min 8 characters, at least 1 upper case character, at least 1 numeric value, exactly 1 special character";
                throw new UserRegistrationException(UserRegistrationException.InvalidationType.INVALID_PHONE_NUMBER, message);
            }
        }
    }
}
