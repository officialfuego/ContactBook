using System;

class Program
{
    static void Main(string[] args)
    {
        ContactBook myBook = new ContactBook();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nContact Book");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("0. Exit");
            Console.Write("Enter: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Contact newContact = GetUserInput();
                myBook.AddContact(newContact);
                Console.WriteLine("Contact added successfully!");
            }
            else if (input == "2")
            {
                Console.WriteLine("\nContacts in your book:");
                myBook.DisplayContacts();
            }
            else if (input == "0")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("That ain't right... Please enter 0, 1, or 2.");
            }
        }

        Console.WriteLine("Cya");
    }

    public static Contact GetUserInput()
    {
        string name;
        while (true)
        {
            Console.Write("Enter contact name: ");
            name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name)) break;
            Console.WriteLine("Name cannot be empty. Please enter a valid name.");
        }

        int phoneNumberInt;
        while (true)
        {
            Console.Write("Enter phone number: ");
            string phoneInput = Console.ReadLine();
            try
            {
                phoneNumberInt = int.Parse(phoneInput);
                break;
            }
            catch
            {
                Console.WriteLine("Invalid phone number. Please enter only numbers.");
            }
        }

        return new Contact(name, phoneNumberInt.ToString());
    }
}
