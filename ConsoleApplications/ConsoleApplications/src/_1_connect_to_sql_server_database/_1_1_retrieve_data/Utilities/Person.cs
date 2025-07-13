namespace ConsoleApplications._1_connect_to_sql_server_database._1_1_retrieve_data.Utilities;

public class Person {
    public int?    contactID { get; }
    public string? firstName { get; }
    public string? lastName  { get; }
    public string? email     { get; }
    public string? phone     { get; }
    public string? address   { get; }
    public int?    countryID { get; }

    public Person(
        int    contactID,
        string firstName,
        string lastName,
        string email,
        string phone,
        string address,
        int    countryID
    ) {
        this.contactID = contactID;
        this.firstName = firstName;
        this.lastName  = lastName;
        this.email     = email;
        this.phone     = phone;
        this.address   = address;
        this.countryID = countryID;
    }
}