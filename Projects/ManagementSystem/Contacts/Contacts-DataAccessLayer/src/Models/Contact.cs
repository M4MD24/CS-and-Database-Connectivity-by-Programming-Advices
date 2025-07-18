using System;

namespace Contacts_DataAccessLayer.Models;

public class Contact {
    public int?      contactID   { get; set; }
    public string?   firstName   { get; set; }
    public string?   lastName    { get; set; }
    public DateTime? dateOfBirth { get; set; }
    public string?   email       { get; set; }
    public string?   phone       { get; set; }
    public string?   address     { get; set; }
    public int?      countryID   { get; set; }

    public Contact() {}

    public Contact(
        int      contactID,
        string   firstName,
        string   lastName,
        DateTime dateOfBirth,
        string   email,
        string   phone,
        string   address,
        int      countryID
    ) {
        this.contactID   = contactID;
        this.firstName   = firstName;
        this.lastName    = lastName;
        this.dateOfBirth = dateOfBirth;
        this.email       = email;
        this.phone       = phone;
        this.address     = address;
        this.countryID   = countryID;
    }

    public Contact(
        string   firstName,
        string   lastName,
        DateTime dateOfBirth,
        string   email,
        string   phone,
        string   address,
        int      countryID
    ) {
        this.firstName   = firstName;
        this.lastName    = lastName;
        this.dateOfBirth = dateOfBirth;
        this.email       = email;
        this.phone       = phone;
        this.address     = address;
        this.countryID   = countryID;
    }
}