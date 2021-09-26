using System;

namespace AddressBook2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Program ");
            AddressClass addressClass = new AddressClass();
            addressClass.acceptData();

            addressClass.display();
        }
    }
}
