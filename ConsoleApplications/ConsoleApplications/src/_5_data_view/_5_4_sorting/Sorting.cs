using System;
using System.Data;

namespace ConsoleApplications._5_data_view._5_4_sorting;

public class Sorting {
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
            3,
            "Youssef",
            "Syria",
            4800,
            DateTime.Now
        );
        employees.Rows.Add(
            6,
            "Mustafa",
            "Iraq",
            4950,
            DateTime.Now
        );
        employees.Rows.Add(
            1,
            "Ahmad",
            "Egypt",
            5000,
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
            2,
            "Omar",
            "Saudi Arabia",
            5200,
            DateTime.Now
        );
        employees.Rows.Add(
            4,
            "Mohamed",
            "Syria",
            5120,
            DateTime.Now
        );

        DataView employeesAsView = employees.DefaultView;

        printEmployees(
            "Before Sorting",
            employeesAsView
        );

        employeesAsView.Sort = "ID";

        printEmployees(
            "After Sorting",
            employeesAsView
        );
    }

    private static void printEmployees(
        string   title,
        DataView employees
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

        if (employees.Count > 0)
            for (
                int index = 0;
                index < employees.Count;
                index++
            )
                printEmployee(
                    employees,
                    index
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
        DataView employee,
        int      index
    ) {
        Console.WriteLine(
            "ID: {0}"      + Environment.NewLine +
            "Name: {1}"    + Environment.NewLine +
            "Country: {2}" + Environment.NewLine +
            "Salary: {3}"  + Environment.NewLine +
            "Date: {4}"    + Environment.NewLine,
            employee[index][0],
            employee[index][1],
            employee[index][2],
            employee[index][3],
            employee[index][4]
        );
    }
}