using System;
using System.Collections.Generic;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateName("Aayush12");
            Console.WriteLine(result);
            bool result1 = pattern.ValidateName("Arya");
            Console.WriteLine(result1);
            bool result2 = pattern.ValidateEmail("abc.acc@gmail.co.in");
            Console.WriteLine(result2);
            bool result3 = pattern.ValidateMobileNo("919998887776");
            Console.WriteLine(result3);
            bool result4 = pattern.ValidatePassword("abcd1234");
            Console.WriteLine(result4);

            EmailList();




        }

        public static void EmailList() 
        {
            List<string> emailList = new List<string>();
            emailList.Add("abc@yahoo.com");
            emailList.Add("abc-100@yahoo.com");
            emailList.Add("abc.100@yahoo.com");
            emailList.Add("abc111@yahoo.com");
            emailList.Add("abc-100@abc.net");
            emailList.Add("abc.100@abc.com.au");
            emailList.Add("abc@1.com");
            emailList.Add("abc@gmail.com.com");
            emailList.Add("abc+100@gmail.com");

            emailList.Add("abc");
            emailList.Add("abc@.com.my");
            emailList.Add("abc123@gmail.a");
            emailList.Add("abc123@.com");
            emailList.Add("abc123@.com.com");
            emailList.Add(".abc@abc.com");
            emailList.Add("abc()*@gmail.com");
            emailList.Add("abc@%*.com");
            emailList.Add("abc..2002@gmail.com");
            emailList.Add("abc.@gmail.com");
            emailList.Add("abc@abc@gmail.com");
            emailList.Add("abc@gmail.com.1a");
            emailList.Add("abc@gmail.com.aa.au");

            Pattern pattern = new Pattern();

            foreach (string email in emailList) 
            {
                
                if (pattern.ValidateEmail(email)) 
                {
                    Console.WriteLine(email + " is valid.");
                }

                else
                {
                    Console.WriteLine(email + " is invalid.");
                }
            }
        }
    }
}
