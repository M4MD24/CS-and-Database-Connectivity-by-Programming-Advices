namespace Contacts_WindowsFormsApplication_PresentationLayer;

partial class Main {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(
        bool disposing
    ) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(
            disposing
        );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        components    = new System.ComponentModel.Container();
        contactList   = new System.Windows.Forms.DataGridView();
        title         = new System.Windows.Forms.Label();
        addNewContact = new System.Windows.Forms.Button();
        contactMenu = new System.Windows.Forms.ContextMenuStrip(
            components
        );
        ((System.ComponentModel.ISupportInitialize) contactList).BeginInit();
        SuspendLayout();
        // 
        // contactList
        // 
        contactList.BackgroundColor             = System.Drawing.Color.Gainsboro;
        contactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        contactList.Location = new System.Drawing.Point(
            5,
            200
        );
        contactList.MultiSelect = false;
        contactList.Name        = "contactList";
        contactList.ReadOnly    = true;
        contactList.Size = new System.Drawing.Size(
            875,
            455
        );
        contactList.TabIndex = 0;
        contactList.Text     = "dataGridView1";
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Fira Code",
            30F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        title.Location = new System.Drawing.Point(
            20,
            20
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            840,
            60
        );
        title.TabIndex  = 1;
        title.Text      = "Contacts Management System";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // addNewContact
        // 
        addNewContact.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        addNewContact.Location = new System.Drawing.Point(
            20,
            120
        );
        addNewContact.Name = "addNewContact";
        addNewContact.Size = new System.Drawing.Size(
            150,
            50
        );
        addNewContact.TabIndex                =  2;
        addNewContact.Text                    =  "Add New Contact";
        addNewContact.UseVisualStyleBackColor =  true;
        addNewContact.Click                   += addNewContact_Click;
        // 
        // contactMenu
        // 
        contactMenu.Name = "contactMenu";
        contactMenu.Size = new System.Drawing.Size(
            61,
            4
        );
        // 
        // main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            884,
            661
        );
        Controls.Add(
            addNewContact
        );
        Controls.Add(
            title
        );
        Controls.Add(
            contactList
        );
        Name          =  "main";
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "Main";
        Load          += main_Load;
        ((System.ComponentModel.ISupportInitialize) contactList).EndInit();
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.ContextMenuStrip contactMenu;

    private System.Windows.Forms.Button addNewContact;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.DataGridView contactList;

    #endregion
}