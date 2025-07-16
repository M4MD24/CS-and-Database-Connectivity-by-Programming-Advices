using System;

namespace Contacts_DataAccessLayer.Models;

public class Country {
    public int?    countryID   { get; set; }
    public string? countryName { get; set; }

    public Country() {}

    public Country(
        int    countryID,
        string countryName
    ) {
        this.countryID   = countryID;
        this.countryName = countryName;
    }

    public Country(
        string countryName
    ) {
        this.countryName = countryName;
    }
}