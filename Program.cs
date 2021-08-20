using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook System Program");
            AddressBookMain abdictonary = new AddressBookMain();

            while (true)
            {
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit Contact\n4.Delete Contact\n5.Search Details\n6.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abdictonary.AddMember();
                        break;

                    case 2:
                        abdictonary.ViewContacts();
                        break;
                    case 3:
                        abdictonary.EditDetails();
                        break;
                    case 4:
                        abdictonary.DeleteDetails();
                        break;
                    case 5:
                        abdictonary.SearchDetails();
                        break;
                    case 6:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;
                }
            }
        }
    }
}
