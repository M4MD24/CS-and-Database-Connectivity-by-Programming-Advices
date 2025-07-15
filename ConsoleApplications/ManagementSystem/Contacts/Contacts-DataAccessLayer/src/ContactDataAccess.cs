using System;
using System.Data.SqlClient;
using Contacts_DataAccessLayer.Utilities;

namespace Contacts_DataAccessLayer;

public class ContactDataAccess {
    public static Contact? getAllContacts() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_ALL_CONTACTS = """
                                           SELECT *
                                           FROM Contacts
                                           """;
        const string QUERY = SELECT_ALL_CONTACTS;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int      contactID = (int) sqlDataReader["ContactID"];
                string   firstName = (string) sqlDataReader["FirstName"];
                string   lastName  = (string) sqlDataReader["LastName"];
                DateTime dateOfBirth = (DateTime) sqlDataReader["DateOfBirth"];
                string   email     = (string) sqlDataReader["Email"];
                string   phone     = (string) sqlDataReader["Phone"];
                string   address   = (string) sqlDataReader["Address"];
                int      countryID = (int) sqlDataReader["CountryID"];
                return new Contact(
                    contactID,
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
                string   firstName = (string) sqlDataReader["FirstName"];
                string   lastName  = (string) sqlDataReader["LastName"];
                DateTime dateOfBirth = (DateTime) sqlDataReader["DateOfBirth"];
                string   email     = (string) sqlDataReader["Email"];
                string   phone     = (string) sqlDataReader["Phone"];
                string   address   = (string) sqlDataReader["Address"];
                int      countryID = (int) sqlDataReader["CountryID"];
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
}