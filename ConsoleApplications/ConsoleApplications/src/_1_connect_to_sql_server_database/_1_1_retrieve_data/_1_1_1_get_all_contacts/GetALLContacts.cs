using System;
using System.Data.SqlClient;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data._1_1_1_get_all_contacts;

public class GetAllContacts {
    public static void printAllContacts() {
        Console.WriteLine(
            "~{ All Contacts }~" + Environment.NewLine
        );

        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_ALL_CONTACTS = "SELECT * FROM Contacts";
        const string QUERY               = SELECT_ALL_CONTACTS;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );

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
                printContact(
                    new Contact(
                        contactID,
                        firstName,
                        lastName,
                        email,
                        phone,
                        address,
                        countryID
                    )
                );
            }

            sqlDataReader.Close();
            sqlConnection.Close();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        }
    }

    private static void printContact(
        Contact contact
    ) {
        Console.WriteLine(
            $"Contact ID: {contact.contactID}" + Environment.NewLine +
            $"First Name: {contact.firstName}" + Environment.NewLine +
            $"Last Name: {contact.lastName}"   + Environment.NewLine +
            $"Email: {contact.email}"          + Environment.NewLine +
            $"Phone: {contact.phone}"          + Environment.NewLine +
            $"Address: {contact.address}"      + Environment.NewLine +
            $"Country ID: {contact.countryID}" + Environment.NewLine
        );
    }

    public static void main() {
        printAllContacts();
    }
}