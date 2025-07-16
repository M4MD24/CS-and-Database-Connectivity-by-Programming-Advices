using System;
using System.Data.SqlClient;
using Contacts_DataAccessLayer.Utilities;

namespace Contacts_DataAccessLayer;

public class ContactDataAccess {
    public static Contact? getContactByContactID(
        int targetContactID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CONTACT_BY_CONTACT_ID = """
                                                    SELECT *
                                                    FROM Contacts
                                                    WHERE ContactID = @targetContactID
                                                    """;
        const string QUERY = SELECT_CONTACT_BY_CONTACT_ID;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@targetContactID",
            targetContactID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string   firstName   = (string) sqlDataReader["FirstName"];
                string   lastName    = (string) sqlDataReader["LastName"];
                DateTime dateOfBirth = (DateTime) sqlDataReader["DateOfBirth"];
                string   email       = (string) sqlDataReader["Email"];
                string   phone       = (string) sqlDataReader["Phone"];
                string   address     = (string) sqlDataReader["Address"];
                int      countryID   = (int) sqlDataReader["CountryID"];
                return new Contact(
                    targetContactID,
                    firstName,
                    lastName,
                    dateOfBirth,
                    email,
                    phone,
                    address,
                    countryID
                );
            }

            sqlDataReader.Close();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }

    public static int addNewContact(
        Contact contact
    ) {
        const string ADD_NEW_CONTACT = """
                                       INSERT INTO Contacts (FirstName, LastName, DateOfBirth, Email, Phone, Address, CountryID)
                                       VALUES (@firstName, @lastName, @dateOfBirth, @email, @phone, @address, @countryID)
                                       """;

        return saveContact(
            ref contact,
            ADD_NEW_CONTACT
        );
    }

    public static int updateContactByContactID(
        int     contactID,
        Contact updatedContact
    ) {
        Contact? contact = getContactByContactID(
            contactID
        );
        if (
            contact == null
        )
            return 0;

        const string UPDATE_DATA = """
                                   UPDATE Contacts
                                   SET FirstName = @firstName,
                                   LastName = @lastName,
                                   DateOfBirth = @dateOfBirth,
                                   Email = @email,
                                   Phone = @phone,
                                   Address = @address,
                                   CountryID = @countryID
                                   WHERE ContactID = @contactID
                                   """;

        updatedContact.contactID = contactID;
        return saveContact(
            ref updatedContact,
            UPDATE_DATA
        );
    }

    private static int saveContact(
        ref Contact contact,
        string      query
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactID",
            contact.contactID
        );
        sqlCommand.Parameters.AddWithValue(
            "@firstName",
            contact.firstName
        );
        sqlCommand.Parameters.AddWithValue(
            "@lastName",
            contact.lastName
        );
        sqlCommand.Parameters.AddWithValue(
            "@dateOfBirth",
            contact.dateOfBirth
        );
        sqlCommand.Parameters.AddWithValue(
            "@email",
            contact.email
        );
        sqlCommand.Parameters.AddWithValue(
            "@phone",
            contact.phone
        );
        sqlCommand.Parameters.AddWithValue(
            "@address",
            contact.address
        );
        sqlCommand.Parameters.AddWithValue(
            "@countryID",
            contact.countryID
        );

        int rowAffected = 0;
        try {
            sqlConnection.Open();
            rowAffected = sqlCommand.ExecuteNonQuery();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return rowAffected;
    }
}