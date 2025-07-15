using System;
using System.Data.SqlClient;
using ConsoleApplications._1_connect_to_sql_server_database.Utilities;

namespace ConsoleApplications._1_connect_to_sql_server_database._1_3_insert_and_add_data_and_retrieve_auto_number_after_inserting_and_adding_data;

public class InsertAndAddDataAndRetrieveAutoNumberAfterInsertingAndAddingData {
    public static void Main(
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
            Constants.CONNECTIVITY
        );
        const string ADD_CONTACT_AND_GET_SCOPE_IDENTITY = """
                                                          INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                                                          VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID)
                                                          SELECT SCOPE_IDENTITY()
                                                          """;
        const string QUERY = ADD_CONTACT_AND_GET_SCOPE_IDENTITY;
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
            object? result = sqlCommand.ExecuteScalar();

            Console.Write(
                (
                    result != null && int.TryParse(
                        result.ToString(),
                        out int insertedID
                    )
                            ? $"\u001B[32mAdded successfully\u001B[0m, Contact ID = {insertedID}"
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