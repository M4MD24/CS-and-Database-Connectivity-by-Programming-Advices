using System;
using System.Data.SqlClient;
using ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data._1_1_5_find_single_contact;

public class FindSingleContact {
    public static void Main(
        string[] args
    ) {
        printContact(
            getContactByContactID(
                4
            )
        );
    }

    private static Person getContactByContactID(
        int contactID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.CONNECTIVITY
        );
        const string SELECT_ALL_CONTACTS = """
                                           SELECT *
                                           FROM Contacts
                                           WHERE ContactID = @contactID
                                           """;
        const string QUERY = SELECT_ALL_CONTACTS;
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

    private static Person getContact(
        ref SqlConnection sqlConnection,
        ref SqlCommand    sqlCommand
    ) {
        Person? person = null;

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
                person = new Person(
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

        return person!;
    }

    private static void printContact(
        Person? person
    ) {
        if (person == null)
            Console.Write(
                "Nothing to Show!"
            );
        else
            Console.Write(
                $"Contact ID: {person.contactID}" + Environment.NewLine +
                $"First Name: {person.firstName}" + Environment.NewLine +
                $"Last Name: {person.lastName}"   + Environment.NewLine +
                $"Email: {person.email}"          + Environment.NewLine +
                $"Phone: {person.phone}"          + Environment.NewLine +
                $"Address: {person.address}"      + Environment.NewLine +
                $"Country ID: {person.countryID}"
            );
    }
}