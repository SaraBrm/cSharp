
using System;
using System.Threading.Channels;

namespace PhonebookByDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositoryContact<Contact> contacts = new RepositoryContact<Contact>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Phonebook (total contact " + contacts.TotalContact + ")");
                DisplayMenu();
                Console.Write("Please select an option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        var newContact = new Contact()
                        {
                            Name = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            Address = Console.ReadLine()
                        };
                        contacts.AddContact(newContact);
                        break;
                    case "2":
                        Console.Write("Please enter phone number to update: ");
                        string phoneNumberToUpdate = Console.ReadLine();
                        contacts.Remove(phoneNumberToUpdate);

                        var updateContact = new Contact()
                        {
                            Name = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            Address = Console.ReadLine()
                        };
                        contacts.AddContact(updateContact);
                        break;
                    case "3":
                        Console.WriteLine("Please enter phone number to remove: ");
                        string phoneToRemove = Console.ReadLine();
                        contacts.Remove(phoneToRemove);
                        break;
                    case "4":
                        Console.Write("Please enter phone number to search: ");
                        string phoneToSearch = Console.ReadLine();
                        var result = contacts[phoneToSearch];
                        //Console.WriteLine("name: "+result.Name+ "phoneNumber: "+result.PhoneNumber+
                        //    "email: "+result.Email+"address: "+result.Address);
                        Console.WriteLine("dsfdsfdsffds");
                        Console.WriteLine($"name: {result.Name}  phoneNumber: {result.PhoneNumber}  email: {result.Email}   address: {result.Address}");
                        break;
                    case "5":
                        Console.WriteLine("My Contacts: ");
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine("Name: "+contact.Name);
                            Console.WriteLine("Phone Number: "+contact.PhoneNumber);
                            Console.WriteLine("Email: "+contact.Email);
                            Console.WriteLine("Address: " + contact.Address);
                        }
                        break;
                    case "6":
                        return;
                        break;
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Update Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Search by Number");
            Console.WriteLine("5. Display Contacts");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
        }


    }
}
