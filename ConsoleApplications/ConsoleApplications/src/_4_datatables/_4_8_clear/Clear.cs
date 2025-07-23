using System;
using System.Data;

namespace ConsoleApplications._4_datatables._4_8_clear;

public class Clear {
    public static void Main() {
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
            "Mohamed",
            "Syria",
            5120,
            DateTime.Now
        );
        employees.Rows.Add(
            5,
            "Ibrahim",
            "Jordan",
            5100,
            DateTime.Now
        );
        employees.Rows.Add(
            6,
            "Mustafa",
            "Iraq",
            4950,
            DateTime.Now
        );

        printEmployees(
            "Before Clear",
            ref employees
        );

        employees.Clear();

        printEmployees(
            "After Clear",
            ref employees
        );
    }

    private static void printEmployees(
        string        title,
        ref DataTable employees
    ) {
        Console.WriteLine(
            new string(
                '-',
                30
            ) + Environment.NewLine
        );

        Console.WriteLine(
            title + Environment.NewLine
        );

        if (employees.Rows.Count > 0)
            foreach (DataRow employee in employees.Rows)
                printEmployee(
                    employee
                );
        else
            Console.WriteLine(
                "Nothing to Show!" + Environment.NewLine
            );

        Console.WriteLine(
            new string(
                '-',
                30
            ) + Environment.NewLine
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
    }
}