CREATE DATABASE Contacts

create table Countries
(
    CountryID   int identity primary key,
    CountryName nvarchar(50)
)

create table Contacts
(
    ContactID   int identity primary key,
    FirstName   nvarchar(50)  not null,
    LastName    nvarchar(50)  not null,
    Email       nvarchar(50)  not null,
    Phone       nvarchar(20)  not null,
    Address     nvarchar(200) not null,
    DateOfBirth datetime      not null,
    CountryID   int           not null references Countries,
    unique (ContactID)
)

