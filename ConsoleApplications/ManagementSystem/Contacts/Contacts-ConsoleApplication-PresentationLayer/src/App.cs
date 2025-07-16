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
        /*
        Contacts_BusinessLayer.ContactBusiness.deleteContactByContactID(
            5
        );
        */
    }
}