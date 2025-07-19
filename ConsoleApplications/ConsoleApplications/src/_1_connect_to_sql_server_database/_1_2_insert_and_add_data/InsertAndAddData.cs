using System;
using System.Data.SqlClient;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_2_insert_and_add_data;

public class InsertAndAddData {
    public static void main(
        string[] args
    ) {
        addContact(
            new Contact(
                "Someone",
                "Example",
                "SomeoneExample@Example.Example",
                "+123456789",
                "Example/Thing",
                1
            )
        );
    }

    private static void addContact(
        Contact contact
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string ADD_CONTACT = """
                                   INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                                   VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID)
                                   """;
        const string QUERY = ADD_CONTACT;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
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
                (rowAffected > 0
                         ? "\u001B[32mAdded successfully"
                         : "\u001B[31mAdded failed") +
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