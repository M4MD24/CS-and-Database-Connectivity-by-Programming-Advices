using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Contacts_DataAccessLayer.Models;
using Contacts_DataAccessLayer.Utilities;

namespace Contacts_DataAccessLayer;

public class CountryDataAccess {
    public static Country? getCountryByCountryID(
        ref int targetCountryID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_COUNTRY_BY_COUNTRY_ID = """
                                                    SELECT *
                                                    FROM Countries
                                                    WHERE CountryID = @targetCountryID
                                                    """;
        const string QUERY = SELECT_COUNTRY_BY_COUNTRY_ID;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@targetCountryID",
            targetCountryID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int    countryID   = (int) sqlDataReader["CountryID"];
                string countryName = (string) sqlDataReader["CountryName"];
                string code        = (string) sqlDataReader["Code"];
                string phoneCode   = (string) sqlDataReader["PhoneCode"];
                return new Country(
                    countryID,
                    countryName,
                    code,
                    phoneCode
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
                string? code = sqlDataReader["Code"] != DBNull.Value
                                       ? (string) sqlDataReader["Code"]
                                       : null;
                string? phoneCode = sqlDataReader["PhoneCode"] != DBNull.Value
                                            ? (string) sqlDataReader["PhoneCode"]
                                            : null;
                return new Country(
                    countryID,
                    countryName,
                    code,
                    phoneCode
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

    public static bool isCountryExistByCountryName(
        ref string countryName
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string IS_COUNTRY_EXIST_BY_COUNTRY_NAME = """
                                                        SELECT Found = 1
                                                        FROM Countries
                                                        WHERE CountryName = @countryName
                                                        """;
        const string QUERY = IS_COUNTRY_EXIST_BY_COUNTRY_NAME;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@countryName",
            countryName
        );

        bool isExist = false;

        try {
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            isExist = sqlDataReader.HasRows;
            sqlDataReader.Close();

            return isExist;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
            return isExist;
        } finally {
            sqlConnection.Close();
        }
    }

    public static List<Country> getAllCountries() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_COUNTRIES = """
                                         SELECT *
                                         FROM Countries
                                         """;
        const string QUERY = GET_ALL_COUNTRIES;
        SqlCommand sqlCommand = new SqlCommand(
            QUERY,
            sqlConnection
        );

        List<Country> countries = [];

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                int    countryID   = (int) sqlDataReader["CountryID"];
                string countryName = (string) sqlDataReader["CountryName"];
                string code        = (string) sqlDataReader["Code"];
                string phoneCode   = (string) sqlDataReader["PhoneCode"];

                countries.Add(
                    new Country(
                        countryID,
                        countryName,
                        code,
                        phoneCode
                    )
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

        return countries;
    }
}