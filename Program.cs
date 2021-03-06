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
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit Contact\n4.Delete Contact\n5.Search Details\n6.Count\n7.SortEntries\n8.Read from file\n9.Save to file\n10.Exit");
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
                        abdictonary.CountByStateOrCity();
                        break;
                    case 7:
                        abdictonary.SortEntries();
                        break;
                    case 8:
                        abdictonary.ReadFromFile();
                        break;
                    case 9:
                        abdictonary.WriteToFile();
                        break;

                    case 10:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;
                }
            }
        }
    }
}
