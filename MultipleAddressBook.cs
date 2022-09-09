using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay36
{
    public  class MultipleAddressBook
    {
        Dictionary<string, AddressBookUC> MultiDict = new Dictionary<string, AddressBookUC>();
        public void AddAddressBook()
        {

            Console.WriteLine("How many ADDRESSBOOK, You want to create ");
            // int BookNum = Convert.ToInt32(Console.ReadLine());
            int BookNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= BookNum; i++)
            {
                AddressBookUC ObjAdd = new AddressBookUC();

                Console.WriteLine("What name you want to give to address book");

                string Bookname = Console.ReadLine();
                MultiDict.Add(Bookname, ObjAdd);


                ObjAdd.AddMultipleContact1();

            }
            Console.WriteLine("AddressBook added successfully");

        }

    }
}
