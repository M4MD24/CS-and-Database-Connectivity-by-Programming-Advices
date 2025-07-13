using System;
using System.Data.SqlClient;
using ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data._1_1_2_parameterized_query;

public class ParameterizedQuery {
    public static void printAllContactsWithFirstName(
        string targetFirstName
    ) {
        Console.WriteLine(
            "~{ All Contacts }~" + Environment.NewLine
        );

        SqlConnection sqlConnection = new SqlConnection(
            Constants.CONNECTIVITY
        );
        const string SELECT_ALL_CONTACTS = """
                                           SELECT *
                                           FROM Contacts
                                           WHERE FirstName = @targetFirstName
                                           """;
        const string QUERY = SELECT_ALL_CONTACTS;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@targetFirstName",
            targetFirstName
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

    public static void Main(
        string[] args
    ) {
        printAllContactsWithFirstName(
            "Emily"
        );
    }
}