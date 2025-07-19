using System;
using System.Data.SqlClient;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data._1_1_4_retrieve_a_single_value;

public class RetrieveA_SingleValue {
    public static void main(
        string[] args
    ) {
        Console.Write(
            "First Name: " +
            getFirstNameByContactID(
                "Single Value",
                4
            )
        );
    }

    private static string getFirstNameByContactID(
        string title,
        int    contactID
    ) {
        Console.WriteLine(
            "~{ " + title + " }~" + Environment.NewLine
        );

        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CONTACT_BY_CONTACT_ID = """
                                                    SELECT FirstName
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

        string firstName = "";

        try {
            sqlConnection.Open();
            object? result = sqlCommand.ExecuteScalar();

            firstName = result != null
                                ? (string) result
                                : "";

            sqlConnection.Close();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        }

        return firstName;
    }
}