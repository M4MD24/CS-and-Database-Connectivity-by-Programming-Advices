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
}