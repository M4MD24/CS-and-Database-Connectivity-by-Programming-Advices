using System;
using System.Collections.Generic;
using Contacts_BusinessLayer;
using Contacts_DataAccessLayer.Models;

namespace Contacts_ConsoleApplication_PresentationLayer;

public class App {
    public static void Main(
        string[] args
    ) {
        forContacts();
        forCountries();
    }

    private static void forCountries() {
        // Find Country by Country Name
        Country? country = findCountryByCountryName(
            "Australia"
        );
        Console.WriteLine(
            "Country Name: " + (
                                   country != null
                                           ? country.countryName
                                           : "?"
                               )
        );

        // Is Country Exist by Country Name
        isCountryExistByCountryName(
            "Australia"
        );
    }

    private static void printContact(
        Contact contact
    ) {
        Console.WriteLine(
            $"Contact ID: {contact.contactID}"      + Environment.NewLine +
            $"First Name: {contact.firstName}"      + Environment.NewLine +
            $"Last Name: {contact.lastName}"        + Environment.NewLine +
            $"Date of Birth: {contact.dateOfBirth}" + Environment.NewLine +
            $"Email: {contact.email}"               + Environment.NewLine +
            $"Phone: {contact.phone}"               + Environment.NewLine +
            $"Address: {contact.address}"           + Environment.NewLine +
            $"Country ID: {contact.countryID}"      + Environment.NewLine
        );
    }

    private static void forContacts() {
        // Find Contact by Contact ID
        Contact? contact = findContactByContactID(
            1
        );
        Console.WriteLine(
            "Full Name: " + (
                                contact != null
                                        ? contact.firstName + " " + contact.lastName
                                        : "?"
                            )
        );

        // Add New Contact
        addNewContact(
            new Contact(
                "Mohamed",
                "Sadawy",
                new DateTime(
                    2003,
                    6,
                    9
                ),
                "m4md24@gmail.com",
                "1555400034",
                "Thing",
                1
            )
        );

        // Update Contact by Contact ID
        updateContactByContactID(
            5,
            new Contact(
                "Mohamed",
                "Sadawy",
                new DateTime(
                    2003,
                    6,
                    9
                ),
                "m4md24@gmail.com",
                "1555400034",
                "Thing",
                1
            )
        );

        // Delete Contact by Contact ID
        deleteContactByContactID(
            5
        );

        // Delete Contact by Contact ID
        foreach (Contact currentContact in getAllContacts())
            printContact(
                currentContact
            );

        // Is Contact Exist by Contact ID
        isContactExistByContactID(
            4
        );
    }

    public static Contact? findContactByContactID(
        int contactID
    ) {
        return ContactBusiness.findContactByContactID(
            ref contactID
        );
    }

    public static void addNewContact(
        Contact contact
    ) {
        Console.WriteLine(
            (
                ContactBusiness.addNewContact(
                    ref contact
                ) > 0
                        ? "\u001B[32mAdded successfully"
                        : "\u001B[31mAdded failed"
            ) +
            "\u001B[0m"
        );
    }

    public static void updateContactByContactID(
        int     contactID,
        Contact contact
    ) {
        Console.WriteLine(
            (
                ContactBusiness.updateContactByContactID(
                    ref contactID,
                    ref contact
                ) > 0
                        ? "\u001B[32mUpdated successfully"
                        : "\u001B[31mUpdated failed"
            ) +
            "\u001B[0m"
        );
    }

    public static void deleteContactByContactID(
        int contactID
    ) {
        if (
            ContactBusiness.isContactExistByContactID(
                ref contactID
            )
        ) {
            Console.WriteLine(
                (
                    ContactBusiness.deleteContactByContactID(
                        ref contactID
                    ) > 0
                            ? "\u001B[32mDeleted successfully"
                            : "\u001B[31mDeleted failed"
                ) +
                "\u001B[0m"
            );
        } else
            Console.WriteLine(
                "\u001B[31mContact isn't Found\u001B[0m"
            );
    }

    public static List<Contact> getAllContacts() {
        return ContactBusiness.getAllContacts();
    }

    public static void isContactExistByContactID(
        int contactID
    ) {
        Console.WriteLine(
            (
                ContactBusiness.isContactExistByContactID(
                    ref contactID
                )
                        ? "\u001B[32mContact is Found"
                        : "\u001B[31mContact isn't Found"
            ) +
            "\u001B[0m"
        );
    }

    public static Country? findCountryByCountryName(
        string countryName
    ) {
        return CountryBusiness.findCountryByCountryName(
            ref countryName
        );
    }

    public static void isCountryExistByCountryName(
        string countryName
    ) {
        Console.WriteLine(
            (
                CountryBusiness.isCountryExistByCountryName(
                    ref countryName
                )
                        ? "\u001B[32mCountry is Found"
                        : "\u001B[31mCountry isn't Found"
            ) +
            "\u001B[0m"
        );
    }
}