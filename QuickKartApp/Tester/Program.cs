using System;
using Library.Models;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Customer Account Creation
             
            int attempts = 3;
            while (attempts > 0)
            {
                Customer cust1 = new Customer();

                //Get all customer details from user
                Console.Write("Enter your address: ");
                string address = Console.ReadLine();

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your DOB using the format YYYY/MM/DD: ");
                string originalDOB = Console.ReadLine();
                string[] dobComponents = originalDOB.Split('/');
                DateTime dob = new DateTime(
                    Convert.ToInt32(dobComponents[0]),
                    Convert.ToInt32(dobComponents[1]),
                    Convert.ToInt32(dobComponents[2]));

                Console.Write("Enter your email ID: ");
                string email = Console.ReadLine();

                Console.Write("Enter your gender: ");
                char gender = Convert.ToChar(Console.ReadLine().Substring(0, 1));


                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                Console.Write("Enter your phone number: ");
                string number = Console.ReadLine();


                //Set customer details
                cust1.Address = address;
                cust1.CustomerName = name;
                cust1.DateOfBirth = dob;
                cust1.EmailId = email;
                cust1.Gender = gender;
                cust1.Password = password;
                cust1.PhoneNumber = number;

                if (cust1.EmailId != "N/A" && cust1.PhoneNumber != "N/A")
                {
                    CustomerDetails custDetails = new CustomerDetails();
                    if (custDetails.AddCustomer(cust1))
                    {
                        Console.WriteLine("\nYou have successfully created a customer account.\n");
                    } else
                    {
                        Console.WriteLine("\nSomething went wrong.\n");
                    }
                    break;
                }

                attempts--;
                Console.WriteLine("\nYou have {0} more attempts to provide valid information.\n", attempts);

            }
            */

            ContactDetails<string> mobile = new ContactDetails<string>(3);
            mobile.AddContact("9845020724");
            mobile.AddContact("7245690129");
            mobile.AddContact("8904421829");

            ContactDetails<string> email = new ContactDetails<string>(3);
            email.AddContact("Jeremy@gmail.com");
            email.AddContact("Anne@gmail.com");
            email.AddContact("Griffeth@gmail.com");

            ContactDetails<string> contacts = new ContactDetails<string>(6);
            contacts.AddContact("9845020724");
            contacts.AddContact("7245690129");
            contacts.AddContact("8904421829");
            contacts.AddContact("Jeremy@gmail.com");
            contacts.AddContact("Anne@gmail.com");
            contacts.AddContact("Griffeth@gmail.com");

            Random randomNumber = new Random();
            int luckyNumber = randomNumber.Next(0, 3);

            string mobileNumber = mobile.GetContactDetails(luckyNumber);
            string emailId = email.GetContactDetails(luckyNumber);
            string luckyContact = contacts.GetContactDetails(luckyNumber);

            Console.WriteLine("Selected lucky mobile number: {0}", mobileNumber);
            Console.WriteLine("Selected lucky email ID: {0}", emailId);
            Console.WriteLine("Selected lucky contact: {0}", luckyContact);
        }
    }
}
