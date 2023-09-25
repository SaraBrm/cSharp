using System;

namespace Phonebook
{
    public class Book
    {
        private Contact[] contacts=new Contact[20];

        public int TotalContact
        {
            get
            {
                int totalContacts = 0;
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] != null)
                        totalContacts++;
                }
                return totalContacts;
            }
        }

        public void Add(Contact contact)
        {
            for (int i = 0; i < contacts.Length; i++) 
            {
                if (contacts[i] == null)
                {
                    contacts[i] = contact;
                    break;
                }
            }
        }

        public Contact CreateContact() 
        {
            Contact newContact = new Contact();
            Console.Write("Name:");
            newContact.Name = Console.ReadLine();
            Console.Write("Phone Number: ");
            newContact.PhoneNumber = Console.ReadLine();
            Console.Write("Email:");
            newContact.Email = Console.ReadLine();
            Console.Write("Address:");
            newContact.Address = Console.ReadLine();
            return newContact;
        }

        public void UpdateContact(string number, Contact contact)
        {
            var oldContact = FindByNumber(number);
            oldContact.Name= contact.Name;
            oldContact.Email= contact.Email;
            oldContact.PhoneNumber= contact.PhoneNumber;
            oldContact.Address=contact.Address;
        }

        public void Remove(string number)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i]!=null && contacts[i].PhoneNumber == number)
                    contacts[i] = null;
            }
        }

        public Contact FindByName(string name)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] != null && contacts[i].Name == name)
                    return contacts[i];
            }
            return null;
        }

        public Contact FindByNumber(string number)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] != null && contacts[i].PhoneNumber == number)
                    return contacts[i];
            }
            return null;
        }
    }
}
