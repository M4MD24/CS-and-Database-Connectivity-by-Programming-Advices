using System.ComponentModel;

namespace Contacts_WindowsFormsApplication_PresentationLayer;

partial class ContactInformation {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        contactID_Question     = new System.Windows.Forms.Label();
        contactID_Information  = new System.Windows.Forms.Label();
        firstNameQuestion      = new System.Windows.Forms.Label();
        firstNameAnswer        = new System.Windows.Forms.TextBox();
        lastNameAnswer         = new System.Windows.Forms.TextBox();
        lastNameQuestion       = new System.Windows.Forms.Label();
        emailAnswer            = new System.Windows.Forms.TextBox();
        emailQuestion          = new System.Windows.Forms.Label();
        phoneAnswer            = new System.Windows.Forms.TextBox();
        phoneQuestion          = new System.Windows.Forms.Label();
        dateOfBirthInformation = new System.Windows.Forms.Label();
        dateOfBirthQuestion    = new System.Windows.Forms.Label();
        dateOfBirthAnswer      = new System.Windows.Forms.DateTimePicker();
        countryNameInformation = new System.Windows.Forms.Label();
        CountryNameQuestion    = new System.Windows.Forms.Label();
        countryNameAnswer      = new System.Windows.Forms.ComboBox();
        addressQuestion        = new System.Windows.Forms.Label();
        addressInformation     = new System.Windows.Forms.Label();
        addressAnswer          = new System.Windows.Forms.TextBox();
        phoneInformation       = new System.Windows.Forms.Label();
        emailInformation       = new System.Windows.Forms.Label();
        lastNameInformation    = new System.Windows.Forms.Label();
        firstNameInformation   = new System.Windows.Forms.Label();
        submit                 = new System.Windows.Forms.Button();
        close                  = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // contactID_Question
        // 
        contactID_Question.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        contactID_Question.Location = new System.Drawing.Point(
            25,
            25
        );
        contactID_Question.Name = "contactID_Question";
        contactID_Question.Size = new System.Drawing.Size(
            150,
            25
        );
        contactID_Question.TabIndex  = 0;
        contactID_Question.Text      = "Contact ID";
        contactID_Question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // contactID_Information
        // 
        contactID_Information.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        contactID_Information.Location = new System.Drawing.Point(
            175,
            25
        );
        contactID_Information.Name = "contactID_Information";
        contactID_Information.Size = new System.Drawing.Size(
            275,
            25
        );
        contactID_Information.TabIndex  = 1;
        contactID_Information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        contactID_Information.Visible   = false;
        // 
        // firstNameQuestion
        // 
        firstNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        firstNameQuestion.Location = new System.Drawing.Point(
            25,
            75
        );
        firstNameQuestion.Name = "firstNameQuestion";
        firstNameQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        firstNameQuestion.TabIndex  = 2;
        firstNameQuestion.Text      = "First Name";
        firstNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // firstNameAnswer
        // 
        firstNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        firstNameAnswer.Location = new System.Drawing.Point(
            175,
            75
        );
        firstNameAnswer.MaxLength = 50;
        firstNameAnswer.Name      = "firstNameAnswer";
        firstNameAnswer.Size = new System.Drawing.Size(
            275,
            25
        );
        firstNameAnswer.TabIndex = 4;
        firstNameAnswer.Visible  = false;
        firstNameAnswer.WordWrap = false;
        // 
        // lastNameAnswer
        // 
        lastNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        lastNameAnswer.Location = new System.Drawing.Point(
            175,
            125
        );
        lastNameAnswer.MaxLength = 50;
        lastNameAnswer.Name      = "lastNameAnswer";
        lastNameAnswer.Size = new System.Drawing.Size(
            275,
            25
        );
        lastNameAnswer.TabIndex = 7;
        lastNameAnswer.Visible  = false;
        lastNameAnswer.WordWrap = false;
        // 
        // lastNameQuestion
        // 
        lastNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        lastNameQuestion.Location = new System.Drawing.Point(
            25,
            125
        );
        lastNameQuestion.Name = "lastNameQuestion";
        lastNameQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        lastNameQuestion.TabIndex  = 5;
        lastNameQuestion.Text      = "Last Name";
        lastNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // emailAnswer
        // 
        emailAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        emailAnswer.Location = new System.Drawing.Point(
            175,
            175
        );
        emailAnswer.MaxLength = 50;
        emailAnswer.Name      = "emailAnswer";
        emailAnswer.Size = new System.Drawing.Size(
            275,
            25
        );
        emailAnswer.TabIndex = 10;
        emailAnswer.Visible  = false;
        emailAnswer.WordWrap = false;
        // 
        // emailQuestion
        // 
        emailQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        emailQuestion.Location = new System.Drawing.Point(
            25,
            175
        );
        emailQuestion.Name = "emailQuestion";
        emailQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        emailQuestion.TabIndex  = 8;
        emailQuestion.Text      = "Email";
        emailQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // phoneAnswer
        // 
        phoneAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        phoneAnswer.Location = new System.Drawing.Point(
            175,
            225
        );
        phoneAnswer.MaxLength = 20;
        phoneAnswer.Name      = "phoneAnswer";
        phoneAnswer.Size = new System.Drawing.Size(
            275,
            25
        );
        phoneAnswer.TabIndex = 13;
        phoneAnswer.Visible  = false;
        phoneAnswer.WordWrap = false;
        // 
        // phoneQuestion
        // 
        phoneQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        phoneQuestion.Location = new System.Drawing.Point(
            25,
            225
        );
        phoneQuestion.Name = "phoneQuestion";
        phoneQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        phoneQuestion.TabIndex  = 11;
        phoneQuestion.Text      = "Phone";
        phoneQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateOfBirthInformation
        // 
        dateOfBirthInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        dateOfBirthInformation.Location = new System.Drawing.Point(
            175,
            275
        );
        dateOfBirthInformation.Name = "dateOfBirthInformation";
        dateOfBirthInformation.Size = new System.Drawing.Size(
            275,
            25
        );
        dateOfBirthInformation.TabIndex  = 15;
        dateOfBirthInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        dateOfBirthInformation.Visible   = false;
        // 
        // dateOfBirthQuestion
        // 
        dateOfBirthQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        dateOfBirthQuestion.Location = new System.Drawing.Point(
            25,
            275
        );
        dateOfBirthQuestion.Name = "dateOfBirthQuestion";
        dateOfBirthQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        dateOfBirthQuestion.TabIndex  = 14;
        dateOfBirthQuestion.Text      = "Date of Birth";
        dateOfBirthQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateOfBirthAnswer
        // 
        dateOfBirthAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        dateOfBirthAnswer.Location = new System.Drawing.Point(
            175,
            275
        );
        dateOfBirthAnswer.Name = "dateOfBirthAnswer";
        dateOfBirthAnswer.Size = new System.Drawing.Size(
            275,
            25
        );
        dateOfBirthAnswer.TabIndex = 17;
        dateOfBirthAnswer.Visible  = false;
        // 
        // countryNameInformation
        // 
        countryNameInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        countryNameInformation.Location = new System.Drawing.Point(
            175,
            325
        );
        countryNameInformation.Name = "countryNameInformation";
        countryNameInformation.Size = new System.Drawing.Size(
            275,
            25
        );
        countryNameInformation.TabIndex  = 19;
        countryNameInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        countryNameInformation.Visible   = false;
        // 
        // CountryNameQuestion
        // 
        CountryNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        CountryNameQuestion.Location = new System.Drawing.Point(
            25,
            325
        );
        CountryNameQuestion.Name = "CountryNameQuestion";
        CountryNameQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        CountryNameQuestion.TabIndex  = 18;
        CountryNameQuestion.Text      = "Country Name";
        CountryNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // countryNameAnswer
        // 
        countryNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        countryNameAnswer.FormattingEnabled = true;
        countryNameAnswer.Location = new System.Drawing.Point(
            175,
            325
        );
        countryNameAnswer.Name = "countryNameAnswer";
        countryNameAnswer.Size = new System.Drawing.Size(
            275,
            25
        );
        countryNameAnswer.TabIndex = 21;
        countryNameAnswer.Visible  = false;
        // 
        // addressQuestion
        // 
        addressQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        addressQuestion.Location = new System.Drawing.Point(
            25,
            375
        );
        addressQuestion.Name = "addressQuestion";
        addressQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        addressQuestion.TabIndex  = 22;
        addressQuestion.Text      = "Address";
        addressQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // addressInformation
        // 
        addressInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        addressInformation.Location = new System.Drawing.Point(
            25,
            400
        );
        addressInformation.Name = "addressInformation";
        addressInformation.Size = new System.Drawing.Size(
            425,
            100
        );
        addressInformation.TabIndex = 24;
        addressInformation.Visible  = false;
        // 
        // addressAnswer
        // 
        addressAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        addressAnswer.Location = new System.Drawing.Point(
            25,
            400
        );
        addressAnswer.MaxLength = 200;
        addressAnswer.Multiline = true;
        addressAnswer.Name      = "addressAnswer";
        addressAnswer.Size = new System.Drawing.Size(
            425,
            100
        );
        addressAnswer.TabIndex    =  25;
        addressAnswer.Visible     =  false;
        addressAnswer.WordWrap    =  false;
        addressAnswer.TextChanged += addressAnswer_TextChanged;
        // 
        // phoneInformation
        // 
        phoneInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        phoneInformation.Location = new System.Drawing.Point(
            175,
            225
        );
        phoneInformation.Name = "phoneInformation";
        phoneInformation.Size = new System.Drawing.Size(
            275,
            25
        );
        phoneInformation.TabIndex  = 12;
        phoneInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        phoneInformation.Visible   = false;
        // 
        // emailInformation
        // 
        emailInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        emailInformation.Location = new System.Drawing.Point(
            175,
            175
        );
        emailInformation.Name = "emailInformation";
        emailInformation.Size = new System.Drawing.Size(
            275,
            25
        );
        emailInformation.TabIndex  = 9;
        emailInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        emailInformation.Visible   = false;
        // 
        // lastNameInformation
        // 
        lastNameInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        lastNameInformation.Location = new System.Drawing.Point(
            175,
            125
        );
        lastNameInformation.Name = "lastNameInformation";
        lastNameInformation.Size = new System.Drawing.Size(
            275,
            25
        );
        lastNameInformation.TabIndex  = 6;
        lastNameInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        lastNameInformation.Visible   = false;
        // 
        // firstNameInformation
        // 
        firstNameInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            14F
        );
        firstNameInformation.Location = new System.Drawing.Point(
            175,
            75
        );
        firstNameInformation.Name = "firstNameInformation";
        firstNameInformation.Size = new System.Drawing.Size(
            275,
            25
        );
        firstNameInformation.TabIndex  = 3;
        firstNameInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        firstNameInformation.Visible   = false;
        // 
        // submit
        // 
        submit.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        submit.Location = new System.Drawing.Point(
            25,
            525
        );
        submit.Name = "submit";
        submit.Size = new System.Drawing.Size(
            200,
            50
        );
        submit.TabIndex                = 26;
        submit.UseVisualStyleBackColor = true;
        submit.Visible                 = false;
        // 
        // close
        // 
        close.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        close.Location = new System.Drawing.Point(
            250,
            525
        );
        close.Name = "close";
        close.Size = new System.Drawing.Size(
            200,
            50
        );
        close.TabIndex                =  27;
        close.Text                    =  "Close";
        close.UseVisualStyleBackColor =  true;
        close.Click                   += close_Click;
        // 
        // ContactInformation
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            484,
            611
        );
        Controls.Add(
            close
        );
        Controls.Add(
            submit
        );
        Controls.Add(
            addressAnswer
        );
        Controls.Add(
            addressInformation
        );
        Controls.Add(
            addressQuestion
        );
        Controls.Add(
            countryNameAnswer
        );
        Controls.Add(
            countryNameInformation
        );
        Controls.Add(
            CountryNameQuestion
        );
        Controls.Add(
            dateOfBirthAnswer
        );
        Controls.Add(
            dateOfBirthInformation
        );
        Controls.Add(
            dateOfBirthQuestion
        );
        Controls.Add(
            phoneAnswer
        );
        Controls.Add(
            phoneInformation
        );
        Controls.Add(
            phoneQuestion
        );
        Controls.Add(
            emailAnswer
        );
        Controls.Add(
            emailInformation
        );
        Controls.Add(
            emailQuestion
        );
        Controls.Add(
            lastNameAnswer
        );
        Controls.Add(
            lastNameInformation
        );
        Controls.Add(
            lastNameQuestion
        );
        Controls.Add(
            firstNameAnswer
        );
        Controls.Add(
            firstNameInformation
        );
        Controls.Add(
            firstNameQuestion
        );
        Controls.Add(
            contactID_Information
        );
        Controls.Add(
            contactID_Question
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Load          += contactInformation_Load;
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.Button close;

    private System.Windows.Forms.Button submit;

    private System.Windows.Forms.Label addressInformation;

    private System.Windows.Forms.Label   addressQuestion;
    private System.Windows.Forms.TextBox addressAnswer;

    private System.Windows.Forms.ComboBox countryNameAnswer;

    private System.Windows.Forms.Label countryNameInformation;
    private System.Windows.Forms.Label CountryNameQuestion;

    private System.Windows.Forms.DateTimePicker dateOfBirthAnswer;

    private System.Windows.Forms.Label phoneQuestion;

    private System.Windows.Forms.Label dateOfBirthQuestion;

    private System.Windows.Forms.TextBox phoneAnswer;
    private System.Windows.Forms.Label   dateOfBirthInformation;
    private System.Windows.Forms.Label   phoneInformation;

    private System.Windows.Forms.TextBox emailAnswer;
    private System.Windows.Forms.Label   emailInformation;
    private System.Windows.Forms.Label   emailQuestion;

    private System.Windows.Forms.TextBox lastNameAnswer;
    private System.Windows.Forms.Label   lastNameInformation;
    private System.Windows.Forms.Label   lastNameQuestion;

    private System.Windows.Forms.TextBox firstNameAnswer;

    private System.Windows.Forms.Label firstNameInformation;
    private System.Windows.Forms.Label firstNameQuestion;

    private System.Windows.Forms.Label contactID_Information;

    private System.Windows.Forms.Label contactID_Question;

    #endregion
}