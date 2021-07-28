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
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AddressBookMain.AddMember();
                        break;
                    case 2:
                        AddressBookMain.ViewContacts();
                        break;

                    case 3:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }
            }
        }
    }
}
