using System;
using System.Data.SqlClient;
using System.Linq;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._2_handle_in_statement;

public class HandleInStatement {
    public static void Main(
        string[] args
    ) {
        deleteContactsByContactIDs(
            5,
            3
        );
    }

    private static void deleteContactsByContactIDs(
        params int[] contactID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.CONNECTIVITY
        );

        string[] contactIDs = contactID.Select(
                                           (
                                                       contactID,
                                                       index
                                                   ) => $"@contactID{index}"
                                       )
                                       .ToArray();
        string query = $"DELETE Contacts WHERE ContactID IN ({
            string.Join(
                ",",
                contactIDs
            )
        })";

        using SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );
        for (
            int index = 0;
            index < contactID.Length;
            index++
        )
            sqlCommand.Parameters.AddWithValue(
                contactIDs[index],
                contactID[index]
            );

        try {
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();

            Console.Write(
                (
                    rowAffected > 0
                            ? "\u001B[32mDeleted successfully"
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