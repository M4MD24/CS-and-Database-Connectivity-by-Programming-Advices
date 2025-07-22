using System;
using System.Data;

namespace ConsoleApplications._4_datatables._4_2_create_offline_data_table_and_list_data;

public class CreateOfflineDataTableAndListData {
    public static void main() {
        DataTable employees = new DataTable();

        employees.Columns.Add(
            "ID",
            typeof(int)
        );
        employees.Columns.Add(
            "Name",
            typeof(string)
        );
        employees.Columns.Add(
            "Country",
            typeof(string)
        );
        employees.Columns.Add(
            "Salary",
            typeof(double)
        );
        employees.Columns.Add(
            "Date",
            typeof(DateTime)
        );

        employees.Rows.Add(
            1,
            "Ahmad",
            "Egypt",
            5000,
            DateTime.Now
        );
        employees.Rows.Add(
            2,
            "Omar",
            "Saudi Arabia",
            5200,
            DateTime.Now
        );
        employees.Rows.Add(
            3,
            "Youssef",
            "Syria",
            4800,
            DateTime.Now
        );
        employees.Rows.Add(
            4,
            "Ibrahim",
            "Jordan",
            5100,
            DateTime.Now
        );
        employees.Rows.Add(
            5,
            "Mustafa",
            "Iraq",
            4950,
            DateTime.Now
        );

        foreach (DataRow employee in employees.Rows)
            printEmployee(
                employee
            );
    }

    private static void printEmployee(
        DataRow employee
    ) {
        Console.WriteLine(
            "ID: {0}"      + Environment.NewLine +
            "Name: {1}"    + Environment.NewLine +
            "Country: {2}" + Environment.NewLine +
            "Salary: {3}"  + Environment.NewLine +
            "Date: {4}"    + Environment.NewLine,
            employee["ID"],
            employee["Name"],
            employee["Country"],
            employee["Salary"],
            employee["Date"]
        );

        /* Another Solution
        Console.WriteLine(
            "ID: {0}" + Environment.NewLine +
            "ID: {1}" + Environment.NewLine +
            "ID: {2}" + Environment.NewLine +
            "ID: {3}" + Environment.NewLine +
            "ID: {4}" + Environment.NewLine,
            employee[0],
            employee[1],
            employee[2],
            employee[3],
            employee[4]
        );
        */
    }
}