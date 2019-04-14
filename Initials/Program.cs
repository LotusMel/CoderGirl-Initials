using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine(Initials(firstName, middleName, lastName));
            Console.ReadLine();
        }

        // TODO: Create a method that takes in a full name and return the initials in all capital letters.

        public static string Initials(string firstName, string middleName, string lastName)
        {
            string firstInitial = firstName.Substring(0,1);
            string middleInitial = middleName.Substring(0,1);
            string lastInitial = lastName.Substring(0,1);
            string initials = firstInitial.ToUpper()
                + middleInitial.ToUpper()
                + lastInitial.ToUpper();
            return initials;
        }
    }
}
