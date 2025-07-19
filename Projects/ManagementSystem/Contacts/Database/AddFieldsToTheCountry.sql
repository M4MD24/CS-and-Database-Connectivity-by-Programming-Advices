USE Contacts

ALTER TABLE Countries
    ADD Code NVARCHAR(3) NULL,
        PhoneCode NVARCHAR(3) NULL;