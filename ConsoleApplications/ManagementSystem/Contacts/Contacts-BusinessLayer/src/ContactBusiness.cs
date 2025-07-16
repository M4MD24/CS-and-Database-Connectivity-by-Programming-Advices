using System;
using Contacts_DataAccessLayer;

namespace Contacts_BusinessLayer;

public class ContactBusiness {
    public static Contact? findContactByContactID(
        int contactID
    ) {
        return ContactDataAccess.getContactByContactID(
            contactID
        );
    }

    public static void addNewContact(
        Contact contact
    ) {
        Console.Write(
            (
                ContactDataAccess.addNewContact(
                    contact
                ) > 0
                        ? "\u001B[32mAdded successfully"
                        : "\u001B[31mAdded failed"
            ) +
            "\u001B[0m"
        );
    }

    public static void updateContactByContactID(
        int     contactID,
        Contact contact
    ) {
        Console.Write(
            (
                ContactDataAccess.updateContactByContactID(
                    contactID,
                    contact
                ) > 0
                        ? "\u001B[32mUpdated successfully"
                        : "\u001B[31mUpdated failed"
            ) +
            "\u001B[0m"
        );
    }
}