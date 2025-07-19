using System;
using System.Collections.Generic;
using Contacts_DataAccessLayer;
using Contacts_DataAccessLayer.Models;

namespace Contacts_BusinessLayer;

public class CountryBusiness {
    public static Country? findCountryByCountryId(
        ref int countryID
    ) {
        return CountryDataAccess.getCountryByCountryID(
            ref countryID
        );
    }

    public static Country? findCountryByCountryName(
        ref string countryName
    ) {
        return CountryDataAccess.getCountryByCountryName(
            ref countryName
        );
    }

    public static bool isCountryExistByCountryName(
        ref string countryName
    ) {
        return CountryDataAccess.isCountryExistByCountryName(
            ref countryName
        );
    }

    public static List<Country> getAllCountries() {
        return CountryDataAccess.getAllCountries();
    }
}