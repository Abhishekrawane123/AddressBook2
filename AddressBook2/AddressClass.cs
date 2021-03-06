using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook2
{
    class AddressClass
    {
        List<User> listUser = new List<User>();
        public void acceptData()
        {
            Console.Write("Enter your First Name :");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last Name :");
            string lastName = Console.ReadLine();
            Console.Write("Enter your Address :");
            string address = Console.ReadLine();
            Console.Write("Enter your City :");
            string city = Console.ReadLine();
            Console.Write("Enter your State :");
            string state = Console.ReadLine();
            Console.Write("Enter your Zip code :");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Phone number :");
            long phoneNo = long.Parse(Console.ReadLine());
            Console.Write("Enter your Email :");
            string email = Console.ReadLine();

            listUser.Add(new User()
            {
                firstName = firstName,
                lastName = lastName,
                address = address,
                city = city,
                state = state,
                zip = zip,
                phoneNo = phoneNo,
                email = email
            });

        }

        public void display()
        {
            foreach (var i in listUser)
            {
                Console.Write("Your First Name is :");
                Console.WriteLine(i.firstName);
                Console.Write("Your Last Name is :");
                Console.WriteLine(i.lastName);
                Console.Write("Your Address is :");
                Console.WriteLine(i.address);
                Console.Write("Your City is :");
                Console.WriteLine(i.city);
                Console.Write("Your State is :");
                Console.WriteLine(i.state);
                Console.Write("Your Zip Code is :");
                Console.WriteLine(i.zip);
                Console.Write("Your Phone Number is :");
                Console.WriteLine(i.phoneNo);
                Console.Write("Your Email is :");
                Console.WriteLine(i.email);
            }
        }

        public void edit(string fName, string lName, string city)
        {
            Boolean find = false;
            for (int i = 0; i < listUser.Count; i++)
            {
                if (listUser[i].firstName.Equals(fName))
                {
                    find = true;
                    listUser[i].lastName = lName;
                    listUser[i].city = city;
                }
                Console.WriteLine("Name And City Changed");
            }
            if (find == false)
            {
                Console.WriteLine("Name is Not Exist");
            }
        }

        public void delete(string fName)
        {
            Boolean find = false;
            for (int i = 0; i < listUser.Count; i++)
            {
                if (listUser[i].firstName.Equals(fName))
                {
                    find = true;
                    listUser.RemoveAt(i);

                }

            }

            if (find == false)
            {
                Console.WriteLine("Name is Not Exist");
            }
            else
            {
                Console.WriteLine("User deleted");
            }
        }
    }
}
