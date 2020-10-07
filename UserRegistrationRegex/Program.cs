using System;

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
            bool result3 = pattern.ValidateMobileNo("91 9998887776");
            Console.WriteLine(result3);
            bool result4 = pattern.ValidatePassword("abcd1234");
            Console.WriteLine(result4);




        }
    }
}
