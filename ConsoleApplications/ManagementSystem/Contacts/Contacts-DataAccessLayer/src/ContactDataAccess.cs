using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Contacts_DataAccessLayer.Utilities;

namespace Contacts_DataAccessLayer;

public class ContactDataAccess {
    public static Contact? getContactByContactID(
        ref int targetContactID
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
        ref Contact contact
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
        ref int     contactID,
        ref Contact updatedContact
    ) {
        Contact? contact = getContactByContactID(
            ref contactID
        );
        if (
            contact == null
        )
            return 0;

        const string UPDATE_DATA_BY_CONTACT_ID = """
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
            UPDATE_DATA_BY_CONTACT_ID
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

    public static int deleteContactByContactID(
        ref int contactID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_DATA_BY_CONTACT_ID = """
                                                 DELETE Contacts
                                                 WHERE ContactID = @contactID
                                                 """;
        const string QUERY = DELETE_DATA_BY_CONTACT_ID;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactID",
            contactID
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

    public static List<Contact> getAllContacts() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_CONTACTS = """
                                        SELECT *
                                        FROM Contacts
                                        """;
        const string QUERY = GET_ALL_CONTACTS;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );

        List<Contact> contacts = [];

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                int      contactID   = (int) sqlDataReader["ContactID"];
                string   firstName   = (string) sqlDataReader["FirstName"];
                string   lastName    = (string) sqlDataReader["LastName"];
                DateTime dateOfBirth = (DateTime) sqlDataReader["DateOfBirth"];
                string   email       = (string) sqlDataReader["Email"];
                string   phone       = (string) sqlDataReader["Phone"];
                string   address     = (string) sqlDataReader["Address"];
                int      countryID   = (int) sqlDataReader["CountryID"];

                contacts.Add(
                    new Contact(
                        contactID,
                        firstName,
                        lastName,
                        dateOfBirth,
                        email,
                        phone,
                        address,
                        countryID
                    )
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

        return contacts;
    }

    public static bool isContactExistByContactID(
        ref int contactID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string IS_CONTACT_EXIST_BY_CONTACT_ID = """
                                                      SELECT Found = 1
                                                      FROM Contacts
                                                      WHERE ContactID = @contactID
                                                      """;
        const string QUERY = IS_CONTACT_EXIST_BY_CONTACT_ID;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@contactID",
            contactID
        );

        bool isExist = false;

        try {
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            isExist = sqlDataReader.HasRows;
            sqlDataReader.Close();

            return isExist;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
            return isExist;
        } finally {
            sqlConnection.Close();
        }
    }
}