using System;
using System.Collections.Generic;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VerifiedList verifiedList = new VerifiedList();
            List<string> fNames = new List<string>() { "Aayush", "AAay", "Aayu", "Saksh","Aayush Aryaa" };
            List<string> result = verifiedList.VerifiedFirstNames(fNames);

            foreach(string x in result) 
            {
                Console.WriteLine(x);
            }
        }
    }
}
