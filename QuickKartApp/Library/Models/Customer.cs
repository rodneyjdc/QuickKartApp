using Library.User_Defined_Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Models
{
    class Customer
    {
        private static int counter;
        private string emailId;
        private int phoneNumber;

        public string Address { get; set; }
        public int CustomerId { 
            get
            {
                return 1000 + counter;
            }
        }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailId { 
            get
            {
                return this.emailId;
            }
            set
            {
                try
                {
                    Regex rgx = new Regex("^([a-zA-Z0-9_\\-\\.]+){7,}@([a-zA-Z0-9_\\-\\.]+)\\.(com)$");
                    if (rgx.IsMatch(value))
                    {
                        this.emailId = value;
                    }
                    else
                    {
                        throw new InvalidEmailIdException("Invalid email ID.");
                    }
                }
                catch (InvalidEmailIdException)
                {
                    this.emailId = "N/A";
                }
                
            }
        }
        public char Gender { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { 
            get
            {
                return this.phoneNumber;
            }
            set
            {
                try
                {
                    Regex rgx = new Regex("^[0-9]{10}$");
                    string val = Convert.ToString(value);
                    if (rgx.IsMatch(val))
                    {
                        this.phoneNumber = value;
                    } else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException)
                {
                    this.phoneNumber = 0;
                }
            }
        }

        public Customer()
        {
            counter++;
        }
    }
}
