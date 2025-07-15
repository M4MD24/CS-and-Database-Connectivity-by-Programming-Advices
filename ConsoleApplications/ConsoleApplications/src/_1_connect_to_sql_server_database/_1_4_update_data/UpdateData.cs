using System;
using System.Data.SqlClient;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_4_update_data;

public class UpdateData {
    public static void main(
        string[] args
    ) {
        updateContactByContactID(
            2,
            new Contact(
                "Someone",
                "Example",
                "SomeoneExample@Example.Example",
                "+123456789",
                "Example/Thing",
                2
            )
        );
    }

    private static void updateContactByContactID(
        int     contactID,
        Contact contact
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.CONNECTIVITY
        );
        const string UPDATE_DATA = """
                                   UPDATE Contacts
                                   SET FirstName = @FirstName,
                                   LastName = @LastName,
                                   Email = @Email,
                                   Phone = @Phone,
                                   Address = @Address,
                                   CountryID = @CountryID
                                   WHERE ContactID = @contactID
                                   """;
        const string QUERY = UPDATE_DATA;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactID",
            contactID
        );
        sqlCommand.Parameters.AddWithValue(
            "@FirstName",
            contact.firstName
        );
        sqlCommand.Parameters.AddWithValue(
            "@LastName",
            contact.lastName
        );
        sqlCommand.Parameters.AddWithValue(
            "@Email",
            contact.email
        );
        sqlCommand.Parameters.AddWithValue(
            "@Phone",
            contact.phone
        );
        sqlCommand.Parameters.AddWithValue(
            "@Address",
            contact.address
        );
        sqlCommand.Parameters.AddWithValue(
            "@CountryID",
            contact.countryID
        );

        try {
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();

            Console.Write(
                (
                    rowAffected > 0
                            ? "\u001B[32mUpdated successfully"
                            : "\u001B[31mUpdated failed") +
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