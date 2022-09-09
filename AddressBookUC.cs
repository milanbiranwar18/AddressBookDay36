using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay36
{
    public class AddressBookUC
    {
        public static List<Contact> People = new List<Contact>();

        public void AddNewContact()
        {
            //Console.WriteLine("Enter the country you want to add address");
            var addressBook = Console.ReadLine();

            Contact person = new Contact();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();


            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            person.ZipCode = Console.ReadLine();


            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();
        }


        public static void PrintAddressBook()
        {
            foreach (Contact contact in People)
            {


                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Address 1: " + contact.Address);
                Console.WriteLine("Address 2: " + contact.ZipCode);
                Console.WriteLine("-------------------------------");
            }

        }
    }
    
}
