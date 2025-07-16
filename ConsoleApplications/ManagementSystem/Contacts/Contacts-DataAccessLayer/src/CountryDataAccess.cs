using System;
using System.Data.SqlClient;
using Contacts_DataAccessLayer.Models;
using Contacts_DataAccessLayer.Utilities;

namespace Contacts_DataAccessLayer;

public class CountryDataAccess {
    public static Country? getCountryByCountryName(
        ref string targetCountryName
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_COUNTRY_BY_COUNTRY_NAME = """
                                                      SELECT *
                                                      FROM Countries
                                                      WHERE CountryName = @targetCountryName
                                                      """;
        const string QUERY = SELECT_COUNTRY_BY_COUNTRY_NAME;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@targetCountryName",
            targetCountryName
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int    countryID   = (int) sqlDataReader["CountryID"];
                string countryName = (string) sqlDataReader["CountryName"];
                return new Country(
                    countryID,
                    countryName
                );
            }

            sqlDataReader.Close();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }

    public static void isCountryExistByCountryName() {}
}