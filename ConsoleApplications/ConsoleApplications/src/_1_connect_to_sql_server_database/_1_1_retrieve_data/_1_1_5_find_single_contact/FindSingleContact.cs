using System;
using System.Data.SqlClient;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data._1_1_5_find_single_contact;

public class FindSingleContact {
    public static void main(
        string[] args
    ) {
        printContact(
            getContactByContactID(
                4
            )
        );
    }

    private static Contact getContactByContactID(
        int contactID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CONTACT_BY_CONTACT_ID = """
                                           SELECT *
                                           FROM Contacts
                                           WHERE ContactID = @contactID
                                           """;
        const string QUERY = SELECT_CONTACT_BY_CONTACT_ID;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactID",
            contactID
        );
        return getContact(
            ref sqlConnection,
            ref sqlCommand
        );
    }

    private static Contact getContact(
        ref SqlConnection sqlConnection,
        ref SqlCommand    sqlCommand
    ) {
        Contact? contact = null;

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int    contactID = (int) sqlDataReader["ContactID"];
                string firstName = (string) sqlDataReader["FirstName"];
                string lastName  = (string) sqlDataReader["LastName"];
                string email     = (string) sqlDataReader["Email"];
                string phone     = (string) sqlDataReader["Phone"];
                string address   = (string) sqlDataReader["Address"];
                int    countryID = (int) sqlDataReader["CountryID"];
                contact = new Contact(
                    contactID,
                    firstName,
                    lastName,
                    email,
                    phone,
                    address,
                    countryID
                );
            }

            sqlDataReader.Close();
            sqlConnection.Close();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        }

        return contact!;
    }

    private static void printContact(
        Contact? contact
    ) {
        if (contact == null)
            Console.Write(
                "Nothing to Show!"
            );
        else
            Console.Write(
                $"Contact ID: {contact.contactID}" + Environment.NewLine +
                $"First Name: {contact.firstName}" + Environment.NewLine +
                $"Last Name: {contact.lastName}"   + Environment.NewLine +
                $"Email: {contact.email}"          + Environment.NewLine +
                $"Phone: {contact.phone}"          + Environment.NewLine +
                $"Address: {contact.address}"      + Environment.NewLine +
                $"Country ID: {contact.countryID}"
            );
    }
}