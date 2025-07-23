using System;
using System.Data;

namespace ConsoleApplications._6_data_set._6_3_access_database_inside_data_set_by_name;

public class AccessDatabaseInsideDataSetByName {
    public static void main() {
        DataTable employees = new(
                      "Employees"
                  ),
                  departments = new(
                      "Departments"
                  );

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

        departments.Columns.Add(
            "ID",
            typeof(int)
        );
        departments.Columns.Add(
            "Name",
            typeof(string)
        );

        departments.Rows.Add(
            1,
            "Developer"
        );
        departments.Rows.Add(
            2,
            "Marketing"
        );
        departments.Rows.Add(
            3,
            "HR"
        );

        DataSet dataSet = new DataSet();
        dataSet.Tables.Add(
            employees
        );
        dataSet.Tables.Add(
            departments
        );

        Console.WriteLine(
            "Employees:"
        );
        printEmployees(
            dataSet.Tables["Employees"]!
        );

        Console.WriteLine();

        Console.WriteLine(
            "Departments:"
        );
        printDepartments(
            dataSet.Tables["Departments"]!
        );
    }

    private static void printEmployee(
        DataRow employee
    ) {
        Console.WriteLine(
            $"ID: {employee["ID"]}, Name: {employee["Name"]}, Country: {employee["Country"]}, Salary: {employee["Salary"]}, Date: {employee["Date"]}"
        );
    }

    private static void printEmployees(
        DataTable employees
    ) {
        foreach (DataRow employee in employees.Rows)
            printEmployee(
                employee
            );
    }

    private static void printDepartment(
        DataRow department
    ) {
        Console.WriteLine(
            $"ID: {department["ID"]}, Name: {department["Name"]}"
        );
    }

    private static void printDepartments(
        DataTable departments
    ) {
        foreach (DataRow department in departments.Rows)
            printDepartment(
                department
            );
    }
}