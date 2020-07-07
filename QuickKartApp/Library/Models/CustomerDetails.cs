using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class CustomerDetails
    {
        private int indexNumber;
        private Customer[] listOfCustomers;

        public CustomerDetails()
        {
            this.indexNumber = 0;
            this.listOfCustomers = new Customer[10];
        }

        bool AddCustomer(Customer customer)
        {
            if (this.indexNumber < 10 && customer != null)
            {
                listOfCustomers[indexNumber] = customer;
                return true;
            }
            return false;
        }

    }
}
