using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class ContactDetails<T>
    {
        //An object array to store any type of contacts 
        //  (i.e. phone numbers and the email ids)
        public T[] Contacts { get; set; }

        //Used to set the size of the array
        public int Size { get; set; }

        //Used to keep track of the index number while adding 
        //  contacts into the object array
        public int Index { get; set; }

        //Parameterized constructor to initialize the instance variables
        public ContactDetails(int size)
        {
            this.Contacts = new T[size];
            this.Size = size;
            this.Index = 0;
        }

        //Add contacts to the object array using the index number
        public void AddContact(T contact)
        {
            if (Index < Size) 
            {
                Contacts[Index++] = contact;
            }
        }

        //Returns the contact present at the index number passed as a parameter
        public T GetContactDetails(int number)
        {
            return Contacts[number];
        }
    }
}
