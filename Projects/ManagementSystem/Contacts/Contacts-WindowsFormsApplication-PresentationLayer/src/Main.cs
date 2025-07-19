using System;
using System.Windows.Forms;
using Contacts_BusinessLayer;

namespace Contacts_WindowsFormsApplication_PresentationLayer;

public partial class Main : Form {
    public enum Mode {
        Add         = 0,
        Update      = 1,
        Information = 2
    }

    public Main() {
        InitializeComponent();
        loadContactMenu();
    }

    private void loadContactMenu() {
        contactList.ContextMenuStrip = contactMenu;

        ToolStripMenuItem information = new(
                              "Information"
                          ),
                          edit = new(
                              "Edit"
                          ),
                          delete = new(
                              "Delete"
                          );

        information.Click += information_Click!;
        edit.Click        += edit_Click!;
        delete.Click      += delete_Click!;

        contactMenu.Items.Add(
            information
        );
        contactMenu.Items.Add(
            edit
        );
        contactMenu.Items.Add(
            delete
        );
    }

    private void addNewContact_Click(
        object    sender,
        EventArgs e
    ) {
        ContactInformation contactInformation = new(
            Mode.Add
        );
        contactInformation.FormClosed += contactForm_FormClosed!;
        contactInformation.Show();
    }

    private void contactForm_FormClosed(
        object              sender,
        FormClosedEventArgs e
    ) {
        loadContacts();
    }

    private void information_Click(
        object    sender,
        EventArgs e
    ) {
        ContactInformation contactInformation = new(
            Mode.Information,
            getContactID_FromContactsList()
        );
        contactInformation.FormClosed += contactForm_FormClosed!;
        contactInformation.Show();
    }

    private void edit_Click(
        object    sender,
        EventArgs e
    ) {
        ContactInformation contactInformation = new(
            Mode.Update,
            getContactID_FromContactsList()
        );
        contactInformation.FormClosed += contactForm_FormClosed!;
        contactInformation.Show();
    }

    private void delete_Click(
        object    sender,
        EventArgs e
    ) {
        int contactID = getContactID_FromContactsList();

        DialogResult deleteQuestionResult = MessageBox.Show(
            $@"Do you want to delete the contact whose contact ID is ({contactID})?",
            @"Delete Question",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        );

        if (deleteQuestionResult != DialogResult.Yes)
            return;

        if (contactID == -1)
            return;

        ContactBusiness.deleteContactByContactID(
            ref contactID
        );

        loadContacts();
    }

    private int getContactID_FromContactsList() {
        if (contactList.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = contactList.SelectedRows[0];
            return Convert.ToInt32(
                selectedRow.Cells[0].Value
            );
        }

        if (contactList.SelectedCells.Count > 0) {
            DataGridViewCell selectedCell = contactList.SelectedCells[0];
            int columnIndex = selectedCell.ColumnIndex,
                rowIndex    = selectedCell.RowIndex;

            if (columnIndex == 0) {
                return Convert.ToInt32(
                    selectedCell.Value
                );
            }

            return Convert.ToInt32(
                contactList.Rows[rowIndex]
                           .Cells[0]
                           .Value
            );
        }

        MessageBox.Show(
            @"Select a contact to delete",
            @"Contact isn't Selected",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );

        return -1;
    }

    private void main_Load(
        object    sender,
        EventArgs e
    ) {
        contactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        loadContacts();
    }

    private void loadContacts() {
        contactList.DataSource = ContactBusiness.getAllContacts();
    }
}