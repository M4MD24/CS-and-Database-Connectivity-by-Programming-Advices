using System;

namespace Contacts_DataAccessLayer.Models;

public class Country {
    public int?    countryID   { get; set; }
    public string? countryName { get; set; }
    public string? code        { get; set; }
    public string? phoneCode   { get; set; }

    public Country() {}

    public Country(
        int    countryID,
        string countryName,
        string code,
        string phoneCode
    ) {
        this.countryID   = countryID;
        this.countryName = countryName;
        this.code        = code;
        this.phoneCode   = phoneCode;
    }

    public Country(
        string countryName,
        string code,
        string phoneCode
    ) {
        this.countryName = countryName;
        this.code        = code;
        this.phoneCode   = phoneCode;
    }
}