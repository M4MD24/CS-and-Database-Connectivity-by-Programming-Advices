using System;
using System.Data.SqlClient;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data._1_1_3_parameterized_query_with_like;

public class ParameterizedQueryWithLike {
    public static void main() {
        printContactsStartsWithInFirstName(
            "Contacts Starts with",
            "j"
        );

        printContactsEndsWithInFirstName(
            "Contacts Ends with",
            "ne"
        );

        printContactsContainsWithInFirstName(
            "Contacts Contains with",
            "ae"
        );
    }

    private static void printContacts(
        SqlConnection sqlConnection,
        SqlCommand    sqlCommand
    ) {
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

    private static void printContactsStartsWithInFirstName(
        string title,
        string targetText
    ) {
        Console.WriteLine(
            "~{ " + title + " in First Name }~" + Environment.NewLine
        );

        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CONTACTS_STARTS_WITH_IN_FIRST_NAME = """
                                                                 SELECT *
                                                                 FROM Contacts
                                                                 WHERE FirstName LIKE '' + @targetText + '%'
                                                                 """;
        const string QUERY = SELECT_CONTACTS_STARTS_WITH_IN_FIRST_NAME;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@targetText",
            targetText
        );

        printContacts(
            sqlConnection,
            sqlCommand
        );
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

    private static void printContactsEndsWithInFirstName(
        string title,
        string targetText
    ) {
        Console.WriteLine(
            "~{ " + title + " in First Name }~" + Environment.NewLine
        );

        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CONTACTS_ENDS_WITH_IN_FIRST_NAME = """
                                                               SELECT *
                                                               FROM Contacts
                                                               WHERE FirstName LIKE '%' + @targetText + ''
                                                               """;
        const string QUERY = SELECT_CONTACTS_ENDS_WITH_IN_FIRST_NAME;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@targetText",
            targetText
        );

        printContacts(
            sqlConnection,
            sqlCommand
        );
    }

    private static void printContactsContainsWithInFirstName(
        string title,
        string targetText
    ) {
        Console.WriteLine(
            "~{ " + title + " in First Name }~" + Environment.NewLine
        );

        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CONTACTS_CONTAINS_WITH_IN_FIRST_NAME = """
                                                                   SELECT *
                                                                   FROM Contacts
                                                                   WHERE FirstName LIKE '%' + @targetText + '%'
                                                                   """;
        const string QUERY = SELECT_CONTACTS_CONTAINS_WITH_IN_FIRST_NAME;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@targetText",
            targetText
        );

        printContacts(
            sqlConnection,
            sqlCommand
        );
    }
}