using System;

namespace AddressBook2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Program ");
            AddressClass addressClass = new AddressClass();
            int count = 0;
            int defCout = 0;
            while (defCout == 0)
            {
                Console.WriteLine("1:Add Contact  2:Display Contact  3:Edit Contact  4:Delete Contact");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressClass.acceptData();
                        break;
                    case 2:
                        addressClass.display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the FirstName to Change the LastName And City");
                        string fName = Console.ReadLine();
                        string lName = Console.ReadLine();
                        string city = Console.ReadLine();
                        addressClass.edit(fName, lName, city);
                        break;
                    case 4:
                        Console.WriteLine("Enter the FirstName to Change the LastName And City");
                        string firstName = Console.ReadLine();
                        addressClass.delete(firstName);
                        break;
                    default:
                        defCout++;
                        break;

                }

            }

        }
    }
}
