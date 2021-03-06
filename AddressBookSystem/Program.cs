using System; 

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Contact contact = new Contact();
            AddressBook addressBook = new AddressBook();
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contact \n 4. Delete Contact \n 5. Multiple Contacts \n 6. Refactor Method \n 7. Checking Duplicate Entry \n 8. Search Person in a City or State \n 9. View Persons by City or State \n 10. Number of Contact persons by City or State \n 11. Sort entries alphabetically by Person's name \n 12. Sort entries by City, State or Zipcode \n 13. Read or Write using File IO \n 14. Read or Write as CSV File \n 15. Read or Write as JSON File \n 16. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to be Edited: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        addressBook.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to be deleted : ");
                        string detail = Console.ReadLine();
                        addressBook.DeleteContact(detail);
                        addressBook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 6:
                        addressBook.AddUniqueContact();
                        addressBook.DisplayUniqueContacts();
                        break;
                    case 7:
                        addressBook.CheckDuplicateEntry();
                        break;
                    case 8:
                        Console.WriteLine("Enter input 1 for City and 2 for State");
                        int result = Convert.ToInt32(Console.ReadLine());
                        if (result == 1)
                        {
                            addressBook.CityList();
                            break;
                        }
                        if (result == 2)
                        {
                            addressBook.StateList();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter correct input");
                        }
                        break;
                    case 9:
                        break;
                    case 10:
                        Console.WriteLine("Enter input 1 for City and 2 for State");
                        int res = Convert.ToInt32(Console.ReadLine());
                        if (res == 1)
                        {
                            addressBook.CityCount();
                            break;
                        }
                        if (res == 2)
                        {
                            addressBook.StateCount();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter correct input");
                        }
                        break;
                    case 11:
                        addressBook.AddressBookSorting();
                        break;
                    case 12:
                        addressBook.SortBy();
                        break;
                    case 13:
                        addressBook.ReadFile();
                        addressBook.WriteUsingStreamWriter();
                        break;
                    case 14:
                        addressBook.ReadWriteAsCsv();
                        break;
                    case 15:
                        addressBook.ReadWriteAsJson();
                        break;
                    case 16:
                        flag = false;
                        break;
                }
            }
        }
    }
}