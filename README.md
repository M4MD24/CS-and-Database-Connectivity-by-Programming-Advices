# C# & Database Connectivity

**Important Note for Console App Projects:** To Run Any File Rename Main Method from "main" to "Main", Because can't run 2 Static "Main" Methods in One Project

- Libraries
    - System.Data.SqlClient

---

1. Concepts
    1. What is XML?
    2. ADO.NET
        1. What is ADO.NET?
        2. ADO.NET Framework Data Providers
        3. ADO.NET Architecture (Components)
    3. [Console Applications](ConsoleApplications/ConsoleApplications)
        1. [Connect to SQL Server Database](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database)
            - [Restore Sample Database](ConsoleApplications/ConsoleApplications/Database)
            1. [Retrieve Data](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_1_retrieve_data)
                1. [Get All Contacts](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_1_retrieve_data/_1_1_1_get_all_contacts)
                2. [Parameterized Query](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_1_retrieve_data/_1_1_2_parameterized_query)
                3. [Parameterized Query With "Like"](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_1_retrieve_data/_1_1_3_parameterized_query_with_like)
                4. [Retrieve a Single Value (ExecuteScalar)](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_1_retrieve_data/_1_1_4_retrieve_a_single_value)
                5. [Find Single Contact](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_1_retrieve_data/_1_1_5_find_single_contact)
            2. [Insert/Add Data](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_2_insert_and_add_data)
            3. [Insert/Add Data and Retrieve Auto Number after Inserting/Adding Data](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_3_insert_and_add_data_and_retrieve_auto_number_after_inserting_and_adding_data)
            4. [Update Data](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_4_update_data)
            5. [Delete Data](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_5_delete_data)
            6. [Handle In Statement](ConsoleApplications/ConsoleApplications/src/_1_connect_to_sql_server_database/_1_6_handle_in_statement)
        2. What are CRUD Operations?
        3. What is 3-Tier Architecture? and Why?
        4. [Datatables](ConsoleApplications/ConsoleApplications/src/_4_datatables)
            1. What is Datatable?
            2. [Create Offline Data Table and List Data](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_2_create_offline_data_table_and_list_data)
            3. [Count, Sum, Avg, Min, Max](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_3_count_and_sum_and_avg_and_min_and_max)
            4. [Filter Data](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_4_filter_data)
            5. [Sorting](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_5_sorting)
            6. [Delete](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_6_delete)
            7. [Update](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_7_update)
            8. [Clear](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_8_clear)
            9. [Primary Key](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_9_primary_key)
            10. [Auto Increment and Others](ConsoleApplications/ConsoleApplications/src/_4_datatables/_4_10_auto_increment_and_others)
        5. DataView
            1. What is DataView?
2. [Projects](Projects)
    1. [Management System](Projects/ManagementSystem)
        1. [Contacts](Projects/ManagementSystem/Contacts)
            1. Find Contact by Contact ID
            2. Add New Contact
            3. Update Contact by Contact ID
            4. Delete Contact by Contact ID
            5. List Contacts
            6. Is Contact Exist by Contact ID
            7. Prepare DataAccess and Business for Countries
                1. Find Country لاy Country Name
                2. Is Country Exist by Country Name
            8. [Add fields to the country](Projects/ManagementSystem/Contacts/Database/AddFieldsToTheCountry.sql)
                1. Code nvarchar(3) allow null
                2. PhoneCode nvarchar(3) allow null
        - [Console Application](Projects/ManagementSystem/Contacts/Contacts-ConsoleApplication-PresentationLayer)
        - [Windows Forms Application](Projects/ManagementSystem/Contacts/Contacts-WindowsFormsApplication-PresentationLayer)