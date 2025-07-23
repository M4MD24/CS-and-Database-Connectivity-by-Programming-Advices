using System;
using System.Data;

namespace ConsoleApplications._5_data_view._5_2_create;

public class Create {
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

        DataView employeesAsView = employees.DefaultView;

        for (
            int index = 0;
            index < employeesAsView.Count;
            index++
        )
            printEmployee(
                employeesAsView,
                index
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