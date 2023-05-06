using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace task
{

    class PhoneBook
    {
        public List<Contact> phoneBook = new List<Contact>();
       

        public void AddContact(Contact contact)
        {

            phoneBook.Add(contact);
        }

        public void DisplayContact(Contact contact)
        {
            Console.WriteLine($"{contact.Name} - {contact.Number}");
        }

        public void DisplayContacts()
        {
            if (phoneBook.Count > 0)
            {
                foreach (Contact contact in phoneBook)
                {
                    Console.WriteLine($"{contact.Name} - {contact.Number}");
                }
            }
            else
            {
                Console.WriteLine("Your phone book is empty");
            }
      
        }

        public void FindNumber(string number)
        {
            var candidate = phoneBook.FirstOrDefault(e => e.Number == number);

            if (candidate != null)
            {
                DisplayContact(candidate);
            }

            else
            {
                Console.WriteLine("Number not found");
            }

        }

        public void FindName(string name)
        {
            var candidate = phoneBook.FirstOrDefault(e => e.Name == name);

            if (candidate != null)
            {
                DisplayContact(candidate);
            }

            else
            {
                Console.WriteLine("Name not found");
            }

        }

        public string ifgood(string m)
        {
            if(m.Length < 3)
            {
                while(m.Length < 3)
                {
                    Console.WriteLine("Name must have at least 3 signs");
                    Console.WriteLine("Insert name");
                    m = Console.ReadLine();
                }
                return m;
            }
            else
            {
                return m;
            }
        }

        public string ifgoodnumber(string m)
        {
            if (m.Length != 9)
            {
                while (m.Length != 9)
                {
                    Console.WriteLine("Number must have 9 numbers");
                    Console.WriteLine("Insert number");
                    m = Console.ReadLine();
                }
                return m;
            }
            else
            {
                return m;
            }
        }

        public void Delete(string num)
        {
            var del = phoneBook.FirstOrDefault(e => e.Number == num);

            if (del != null)
            {
                Console.WriteLine("Deleting contact...");
                phoneBook.Remove(del);
            }

            else
            {
                Console.WriteLine("This number does not exist in your phone book");
            }
        }
    }
}
