// See https://aka.ms/new-console-template for more information
using AddressBookDay36;

Console.WriteLine("Wellcome to the Address Book Problem");

AddressBookUC obj = new AddressBookUC();
//obj.AddNewContact();
//AddressBookUC.PrintAddressBook();

Console.WriteLine("Enter the FirstName to Edit");
string firstName = Console.ReadLine();
obj.EditContact(firstName);
AddressBookUC.PrintAddressBook();
