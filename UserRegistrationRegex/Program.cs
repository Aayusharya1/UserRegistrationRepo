using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFname("Aayush12");
            Console.WriteLine(result);
        }
    }
}
