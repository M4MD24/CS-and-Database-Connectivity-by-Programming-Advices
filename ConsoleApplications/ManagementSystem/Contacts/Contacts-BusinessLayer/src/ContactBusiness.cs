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

    public static void addNewData(
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
}