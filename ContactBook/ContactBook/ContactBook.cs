using System;
using System.Collections.Generic;

public class ContactBook
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    public void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("You ain't got no contacts.");
            return;
        }

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Name} - {contact.PhoneNumber}");
        }
    }
}
