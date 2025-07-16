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
}