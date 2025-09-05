using System;
using System.Collections.Generic;

public class ContactBook
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact newContact)
    {
        contacts.Add(newContact);
    }

    public void DisplayContacts()
    {
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Name} - {contact.PhoneNumber}");
        }
    }
}
