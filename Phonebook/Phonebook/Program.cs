using System;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Phonebook (total contact " + book.TotalContact + ")");
                DisplayMenu();
                Console.Write("Please select an option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        var newContact=book.CreateContact();
                        book.Add(newContact);
                        break;
                    case "2":
                        Console.Write("Please enter phone number to update: ");
                        string phoneNumberToUpdate = Console.ReadLine();
                        Contact contactToUpdate = book.FindByNumber(phoneNumberToUpdate);
                        if (contactToUpdate != null)
                        {
                            var updatedContact = book.CreateContact();
                            book.UpdateContact(phoneNumberToUpdate,updatedContact);
                        }
                        else
                            Console.WriteLine("Contact with phone" + phoneNumberToUpdate + "was not found");
                        break;
                    case "3":
                        Console.WriteLine("Please enter phone number to remove: ");
                        string phoneToRemove=Console.ReadLine();
                        book.Remove(phoneToRemove);
                        break;
                    case "4":
                        Console.Write("Please enter name to search: ");
                        string nameToSearch = Console.ReadLine();
                        Contact contactByName = book.FindByName(nameToSearch);
                        if (contactByName != null)
                        {
                            DisplayContactInformation(contactByName);
                        }
                        else
                            Console.WriteLine("Contact with name" + contactByName + "was not found");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Write("Please enter phone number to search: ");
                        string phoneNumberToSearch=Console.ReadLine();
                        Contact contactByNumber= book.FindByNumber(phoneNumberToSearch);
                        if(contactByNumber!=null)
                        {
                            DisplayContactInformation(contactByNumber);
                        }
                        else
                            Console.WriteLine("Contact with phone"+phoneNumberToSearch+"was not found");
                        Console.ReadKey();
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
            Console.WriteLine("4. Search by Name");
            Console.WriteLine("5. Search by Number");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
        }

        private static void DisplayContactInformation(Contact contact)
        {
            Console.WriteLine("Name:" + contact.Name);
            Console.WriteLine("Phone Number:" + contact.PhoneNumber);
            Console.WriteLine("Email:" + contact.Email);
            Console.WriteLine("Address:" + contact.Address);
        }
    }
}
