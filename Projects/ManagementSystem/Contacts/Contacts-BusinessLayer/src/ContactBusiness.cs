using System;
using System.Collections.Generic;
using Contacts_DataAccessLayer;
using Contacts_DataAccessLayer.Models;

namespace Contacts_BusinessLayer;

public class ContactBusiness {
    public static Contact? findContactByContactID(
        ref int contactID
    ) {
        return ContactDataAccess.getContactByContactID(
            ref contactID
        );
    }

    public static int addNewContact(
        ref Contact contact
    ) {
        return ContactDataAccess.addNewContact(
            ref contact
        );
    }

    public static int updateContactByContactID(
        ref int     contactID,
        ref Contact contact
    ) {
        return ContactDataAccess.updateContactByContactID(
            ref contactID,
            ref contact
        );
    }

    public static int deleteContactByContactID(
        ref int contactID
    ) {
        return ContactDataAccess.isContactExistByContactID(
                   ref contactID
               )
                       ? ContactDataAccess.deleteContactByContactID(
                           ref contactID
                       )
                       : -1;
    }

    public static List<Contact> getAllContacts() {
        return ContactDataAccess.getAllContacts();
    }

    public static bool isContactExistByContactID(
        ref int contactID
    ) {
        return ContactDataAccess.isContactExistByContactID(
            ref contactID
        );
    }
}