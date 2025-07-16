using System;
using Contacts_DataAccessLayer;

namespace Contacts_ConsoleApplication_PresentationLayer;

public class App {
    public static void Main(
        string[] args
    ) {
        // Find Contact by Contact ID
        /*
        Contact? contact = Contacts_BusinessLayer.ContactBusiness.findContactByContactID(
            1
        );
        Console.WriteLine(
            "Full Name: " + (
                                contact != null
                                        ? contact.firstName + " " + contact.lastName
                                        : "?"
                            )
        );
        */

        // Add New Contact
        /*
        Contacts_BusinessLayer.ContactBusiness.addNewContact(
            new Contact(
                "Mohamed",
                "Sadawy",
                new DateTime(
                    2003,
                    6,
                    9
                ),
                "m4md24@gmail.com",
                "+201555400034",
                "Thing",
                1
            )
        );
        */

        // Update Contact by Contact ID
        /*
        Contacts_BusinessLayer.ContactBusiness.updateContactByContactID(
            5,
            new Contact(
                "Mohamed",
                "Sadawy",
                new DateTime(
                    2003,
                    6,
                    9
                ),
                "m4md24@gmail.com",
                "+201555400034",
                "Thing",
                1
            )
        );
        */

        // Delete Contact by Contact ID
        Contacts_BusinessLayer.ContactBusiness.deleteContactByContactID(
            5
        );

        // Delete Contact by Contact ID
        /*
        foreach (Contact contact in Contacts_BusinessLayer.ContactBusiness.getAllContacts())
            printContact(
                contact
            );
        */

        // Is Contact Exist by Contact ID
        /*
        Contacts_BusinessLayer.ContactBusiness.isContactExistByContactID(
            4
        );
        */
    }

    private static void printContact(
        Contact contact
    ) {
        Console.WriteLine(
            $"Contact ID: {contact.contactID}"      + Environment.NewLine +
            $"First Name: {contact.firstName}"      + Environment.NewLine +
            $"Last Name: {contact.lastName}"        + Environment.NewLine +
            $"Date of Birth: {contact.dateOfBirth}" + Environment.NewLine +
            $"Email: {contact.email}"               + Environment.NewLine +
            $"Phone: {contact.phone}"               + Environment.NewLine +
            $"Address: {contact.address}"           + Environment.NewLine +
            $"Country ID: {contact.countryID}"      + Environment.NewLine
        );
    }
}