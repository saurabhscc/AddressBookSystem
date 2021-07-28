using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook System Program");
            while (true)
            {
                Console.WriteLine("**************=================****************");
                Console.WriteLine("Enter First Name ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter address ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State: ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Zip Code: ");
                int zipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number: ");
                string phNo = Console.ReadLine();
                Console.Write("Enter Email-id: ");
                string emailId = Console.ReadLine();
                break;
            }
        }
    }
}
