using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new PhoneBook();
            var choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("Choose what you want to do: ");
                Console.WriteLine("1 - Add contact");
                Console.WriteLine("2 - Search by number");
                Console.WriteLine("3 - See all the contacts");
                Console.WriteLine("4 - Search by name");
                Console.WriteLine("5 - Delete contact");
                Console.WriteLine("6 - Exit");
                Console.WriteLine();

                choice = int.Parse(Console.ReadLine());


                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("Type in a name:");
                        var name = Console.ReadLine();
                        name = phone.ifgood(name);

                        Console.WriteLine("Type in a number:");
                        var number = Console.ReadLine();
                        number = phone.ifgoodnumber(number);
                        
                        var person = new Contact(name, number);
                   
                        phone.AddContact(person);
                        break;

                    case 2:
                        Console.WriteLine("Type in a number:");
                        var findNumber = Console.ReadLine();
                        phone.FindNumber(findNumber);
                        break;

                    case 3:
                        phone.DisplayContacts();
                        break;

                    case 4:
                        Console.WriteLine("Type in a number:");
                        var findName = Console.ReadLine();
                        phone.FindName(findName);
                        break;

                    case 5:
                        Console.WriteLine("Insert number which you want to delete:");
                        var deleteNumber = Console.ReadLine();
                        deleteNumber = phone.ifgoodnumber(deleteNumber);
                        phone.Delete(deleteNumber);
                        break;

                    case 6:
                        Console.WriteLine("Exit app");
                        break;

                    default:
                        Console.WriteLine("Choose number of operation from 1 to 5");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }

}
