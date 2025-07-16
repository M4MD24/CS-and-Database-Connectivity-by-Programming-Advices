using System;
using System.Collections.Generic;
using Contacts_DataAccessLayer;
using Contacts_DataAccessLayer.Models;

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
        Console.WriteLine(
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
        Console.WriteLine(
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
        if (
            ContactDataAccess.isContactExistByContactID(
                ref contactID
            )
        ) {
            Console.WriteLine(
                (
                    ContactDataAccess.deleteContactByContactID(
                        ref contactID
                    ) > 0
                            ? "\u001B[32mDeleted successfully"
                            : "\u001B[31mDeleted failed"
                ) +
                "\u001B[0m"
            );
        } else
            Console.WriteLine(
                "\u001B[31mContact isn't Found"
            );
    }

    public static List<Contact> getAllContacts() {
        return ContactDataAccess.getAllContacts();
    }

    public static void isContactExistByContactID(
        int contactID
    ) {
        Console.WriteLine(
            (
                ContactDataAccess.isContactExistByContactID(
                    ref contactID
                )
                        ? "\u001B[32mContact is Found"
                        : "\u001B[31mContact isn't Found"
            ) +
            "\u001B[0m"
        );
    }
}