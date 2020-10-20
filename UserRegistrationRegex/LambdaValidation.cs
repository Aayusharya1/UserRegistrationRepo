using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class VerifiedList
    {
        Pattern pattern = new Pattern();

        public List<string> VerifiedFirstNames(List<string> fNameList)
        {
            //returns valid first names in the list
            return fNameList.FindAll(fName => Regex.IsMatch(fName, pattern.Regex_Name));
        }

        public List<string> VerifiedLastNames(List<string> lNameList)
        {
            //returns valid last names in the list
            return lNameList.FindAll(lName => Regex.IsMatch(lName, pattern.Regex_Name));
        }

        public List<string> VerifiedEmailList(List<string> emailList)
        {
            //return valid mail ids in list
            return emailList.FindAll(email => Regex.IsMatch(email, pattern.Regex_email));
        }

        public List<string> VerifiedPhoneNumber(List<string> phNumList)
        {
            //returns valid phone number list
            return phNumList.FindAll(phNum => Regex.IsMatch(phNum, pattern.Regex_MobNo));
        }

        public List<string> VerifiedPasswords(List<string> passwords)
        {
            //returns valid password lists
            return passwords.FindAll(password => Regex.IsMatch(password, pattern.Regex_Password));
        }
    }
}