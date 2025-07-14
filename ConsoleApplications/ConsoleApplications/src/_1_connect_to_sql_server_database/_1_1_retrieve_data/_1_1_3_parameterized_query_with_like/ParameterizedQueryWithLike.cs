using System;
using System.Data.SqlClient;
using ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data._1_1_3_parameterized_query_with_like;

public class ParameterizedQueryWithLike {
    public static void Main(
        string[] args
    ) {
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
                    new Person(
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
            Constants.CONNECTIVITY
        );
        const string SELECT_ALL_CONTACTS = """
                                           SELECT *
                                           FROM Contacts
                                           WHERE FirstName LIKE '' + @targetText + '%'
                                           """;
        const string QUERY = SELECT_ALL_CONTACTS;
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
        Person person
    ) {
        Console.WriteLine(
            $"Contact ID: {person.contactID}" + Environment.NewLine +
            $"First Name: {person.firstName}" + Environment.NewLine +
            $"Last Name: {person.lastName}"   + Environment.NewLine +
            $"Email: {person.email}"          + Environment.NewLine +
            $"Phone: {person.phone}"          + Environment.NewLine +
            $"Address: {person.address}"      + Environment.NewLine +
            $"Country ID: {person.countryID}" + Environment.NewLine
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
            Constants.CONNECTIVITY
        );
        const string SELECT_ALL_CONTACTS = """
                                           SELECT *
                                           FROM Contacts
                                           WHERE FirstName LIKE '%' + @targetText + ''
                                           """;
        const string QUERY = SELECT_ALL_CONTACTS;
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
            Constants.CONNECTIVITY
        );
        const string SELECT_ALL_CONTACTS = """
                                           SELECT *
                                           FROM Contacts
                                           WHERE FirstName LIKE '%' + @targetText + '%'
                                           """;
        const string QUERY = SELECT_ALL_CONTACTS;
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