using System;
using System.Data.SqlClient;
using ConsoleApplications._1_connect_to_sql_server_database.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_5_delete_data;

public class DeleteData {
    public static void Main(
        string[] args
    ) {
        deleteContactByContactID(
            2
        );
    }

    private static void deleteContactByContactID(
        int contactID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.CONNECTIVITY
        );
        const string DELETE_DATA = """
                                   DELETE Contacts
                                   WHERE ContactID = @contactID
                                   """;
        const string QUERY = DELETE_DATA;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactID",
            contactID
        );

        try {
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();

            Console.Write(
                (
                    rowAffected > 0
                            ? $"\u001B[32mDeleted successfully"
                            : "\u001B[31mDeleted failed") +
                "\u001B[0m"
            );

            sqlConnection.Close();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        }
    }
}