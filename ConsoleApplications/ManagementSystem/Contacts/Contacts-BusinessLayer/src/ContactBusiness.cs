using System;
using System.Collections.Generic;
using Contacts_DataAccessLayer;

namespace Contacts_BusinessLayer;

public class ContactBusiness {
    public static Contact? findContactByContactID(
        int contactID
    ) {
        return ContactDataAccess.getContactByContactID(
            ref contactID
        );
    }

    public static void addNewContact(
        Contact contact
    ) {
        Console.Write(
            (
                ContactDataAccess.addNewContact(
                    ref contact
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
                    ref contactID,
                    ref contact
                ) > 0
                        ? "\u001B[32mUpdated successfully"
                        : "\u001B[31mUpdated failed"
            ) +
            "\u001B[0m"
        );
    }

    public static void deleteContactByContactID(
        int contactID
    ) {
        Console.Write(
            (
                ContactDataAccess.deleteContactByContactID(
                    ref contactID
                ) > 0
                        ? "\u001B[32mDeleted successfully"
                        : "\u001B[31mDeleted failed"
            ) +
            "\u001B[0m"
        );
    }

    public static List<Contact> getAllContacts() {
        return ContactDataAccess.getAllContacts();
    }
}