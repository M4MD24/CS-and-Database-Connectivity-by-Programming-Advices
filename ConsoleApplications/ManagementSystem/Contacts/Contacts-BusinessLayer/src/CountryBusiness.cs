using System;
using Contacts_DataAccessLayer;
using Contacts_DataAccessLayer.Models;

namespace Contacts_BusinessLayer;

public class CountryBusiness {
    public static Country? findCountryByCountryName(
        string countryName
    ) {
        return CountryDataAccess.getCountryByCountryName(
            ref countryName
        );
    }

    public static void isCountryExistByCountryName(
        string countryName
    ) {
        Console.WriteLine(
            (
                CountryDataAccess.isCountryExistByCountryName(
                    ref countryName
                )
                        ? "\u001B[32mCountry is Found"
                        : "\u001B[31mCountry isn't Found"
            ) +
            "\u001B[0m"
        );
    }
}