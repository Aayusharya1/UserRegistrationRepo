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
        }
    }
}
