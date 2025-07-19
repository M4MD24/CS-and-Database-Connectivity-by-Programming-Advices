using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Contacts_DataAccessLayer.Models;

namespace Contacts_WindowsFormsApplication_PresentationLayer;

public partial class ContactInformation : Form {
    public ContactInformation(
        Main.Mode mode,
        int       contactID = -1
    ) {
        InitializeComponent();

        Contact? contact = null;
        if (contactID != -1)
            contact = Contacts_BusinessLayer.ContactBusiness.findContactByContactID(
                ref contactID
            )!;

        switch (mode) {
            case Main.Mode.Information:
                initializeInformationForm(
                    ref contact!
                );
            break;
            case Main.Mode.Add:
                initializeAdditionForm();
            break;
            case Main.Mode.Update:
                initializeModificationForm(
                    ref contact!
                );
            break;
        }
    }

    private void initializeInformationForm(
        ref Contact contact
    ) {
        Text = @"Information Contact";

        contactID_Information.Visible  = true;
        firstNameInformation.Visible   = true;
        lastNameInformation.Visible    = true;
        emailInformation.Visible       = true;
        phoneInformation.Visible       = true;
        dateOfBirthInformation.Visible = true;
        countryNameInformation.Visible = true;
        addressInformation.Visible     = true;

        loadContactForInformation(
            ref contact
        );
    }

    private void loadContactForInformation(
        ref Contact contact
    ) {
        contactID_Information.Text = contact.contactID.ToString();
        firstNameInformation.Text  = contact.firstName;
        lastNameInformation.Text   = contact.lastName;
        emailInformation.Text      = contact.email;
        phoneInformation.Text      = contact.phone;
        dateOfBirthInformation.Text = Convert.ToDateTime(
                                                 contact.dateOfBirth
                                             )
                                             .ToString(
                                                 CultureInfo.CurrentCulture
                                             );
        countryNameInformation.Text = getCountryNameFromContact(
            ref contact
        );
        addressInformation.Text = contact.address;
    }

    private void contactInformation_Load(
        object    sender,
        EventArgs e
    ) {
        loadCountryNames();
    }

    private void initializeModificationForm(
        ref Contact contact
    ) {
        Text = @"Update Contact";

        firstNameAnswer.Visible   = true;
        lastNameAnswer.Visible    = true;
        emailAnswer.Visible       = true;
        phoneAnswer.Visible       = true;
        dateOfBirthAnswer.Visible = true;
        countryNameAnswer.Visible = true;
        addressAnswer.Visible     = true;

        contactID_Information.Visible = true;

        loadContactForModification(
            ref contact
        );

        int contactID = contact.contactID ?? throw new Exception(
                            "contactID is null"
                        );

        submit.Click += (
            sender,
            e
        ) => update_Click(
            contactID,
            sender!,
            e
        );
        submit.Text    = @"Update";
        submit.Visible = true;
    }

    private void loadContactForModification(
        ref Contact contact
    ) {
        contactID_Information.Text = contact.contactID.ToString();
        firstNameAnswer.Text       = contact.firstName;
        lastNameAnswer.Text        = contact.lastName;
        emailAnswer.Text           = contact.email;
        phoneAnswer.Text           = contact.phone;
        dateOfBirthAnswer.Text = Convert.ToDateTime(
                                            contact.dateOfBirth
                                        )
                                        .ToString(
                                            CultureInfo.CurrentCulture
                                        );
        countryNameAnswer.Text = getCountryNameFromContact(
            ref contact
        );
        addressAnswer.Text = contact.address;
    }

    private string getCountryNameFromContact(
        ref Contact contact
    ) {
        int countryID = contact.countryID ?? throw new Exception(
                            "countryID is null"
                        );
        return Contacts_BusinessLayer.CountryBusiness.findCountryByCountryId(
                                         ref countryID
                                     )!
                                     .countryName!;
    }

    private void initializeAdditionForm() {
        Text = @"Add New Contact";

        contactID_Question.Enabled = false;

        firstNameAnswer.Visible   = true;
        lastNameAnswer.Visible    = true;
        emailAnswer.Visible       = true;
        phoneAnswer.Visible       = true;
        dateOfBirthAnswer.Visible = true;
        countryNameAnswer.Visible = true;
        addressAnswer.Visible     = true;

        submit.Click   += save_Click!;
        submit.Text    =  @"Save";
        submit.Visible =  true;
    }

    private void loadCountryNames() {
        foreach (Country countryName in Contacts_BusinessLayer.CountryBusiness.getAllCountries())
            countryNameAnswer.Items.Add(
                countryName.countryName!
            );
    }

    private void close_Click(
        object    sender,
        EventArgs e
    ) {
        Close();
    }

    private void update_Click(
        int       contactID,
        object    sender,
        EventArgs e
    ) {
        string firstName = firstNameAnswer.Text;
        string lastName  = lastNameAnswer.Text;
        DateTime dateOfBirth = Convert.ToDateTime(
            dateOfBirthAnswer.Text
        );
        string email     = emailAnswer.Text;
        string phone     = phoneAnswer.Text;
        string address   = addressAnswer.Text;
        int    countryID = getCountryID_FromCountryName();

        Contact contact = new Contact(
            firstName,
            lastName,
            dateOfBirth,
            phone,
            email,
            address,
            countryID
        );

        Contacts_BusinessLayer.ContactBusiness.updateContactByContactID(
            ref contactID,
            ref contact
        );

        Close();
    }

    private void save_Click(
        object    sender,
        EventArgs e
    ) {
        string firstName = firstNameAnswer.Text;
        string lastName  = lastNameAnswer.Text;
        DateTime dateOfBirth = Convert.ToDateTime(
            dateOfBirthAnswer.Text
        );
        string email     = emailAnswer.Text;
        string phone     = phoneAnswer.Text;
        string address   = addressAnswer.Text;
        int    countryID = getCountryID_FromCountryName();

        Contact contact = new Contact(
            firstName,
            lastName,
            dateOfBirth,
            phone,
            email,
            address,
            countryID
        );

        Contacts_BusinessLayer.ContactBusiness.addNewContact(
            ref contact
        );

        Close();
    }

    private int getCountryID_FromCountryName() {
        string countryName = countryNameAnswer.Text;
        Country country = Contacts_BusinessLayer.CountryBusiness.findCountryByCountryName(
            ref countryName
        )!;
        return country.countryID ?? throw new Exception(
                   "countryID is null"
               );
    }

    private void addressAnswer_TextChanged(
        object    sender,
        EventArgs e
    ) {
        const int      MAXIMUM_LINES = 4;
        string[] lines    = addressAnswer.Lines;

        if (lines.Length <= MAXIMUM_LINES)
            return;
        addressAnswer.Lines = lines.Take(
                                       MAXIMUM_LINES
                                   )
                                   .ToArray();

        addressAnswer.SelectionStart = addressAnswer.Text.Length;
    }
}