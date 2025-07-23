using System;
using System.Data;

namespace ConsoleApplications._4_datatables._4_10_auto_increment_and_others;

public class AutoIncrementAndOthers {
    public static void Main() {
        DataTable employees = new DataTable();

        employees.Columns.Add(
            defineColumn(
                "ID",
                typeof(int),
                true,
                caption : "Employee ID",
                isReadOnly : true,
                isUnique : true
            )
        );
        employees.Columns.Add(
            defineColumn(
                "Name",
                typeof(string),
                caption : "Employee Name"
            )
        );
        employees.Columns.Add(
            defineColumn(
                "Country",
                typeof(string),
                caption : "Employee Country"
            )
        );
        employees.Columns.Add(
            defineColumn(
                "Salary",
                typeof(double),
                caption : "Employee Salary"
            )
        );
        employees.Columns.Add(
            defineColumn(
                "Date",
                typeof(DateTime),
                caption : "Employee Date"
            )
        );

        employees.Rows.Add(
            null,
            "Ahmad",
            "Egypt",
            5000,
            DateTime.Now
        );
        employees.Rows.Add(
            null,
            "Omar",
            "Saudi Arabia",
            5200,
            DateTime.Now
        );
        employees.Rows.Add(
            null,
            "Youssef",
            "Syria",
            4800,
            DateTime.Now
        );
        employees.Rows.Add(
            null,
            "Mohamed",
            "Syria",
            5120,
            DateTime.Now
        );
        employees.Rows.Add(
            null,
            "Ibrahim",
            "Jordan",
            5100,
            DateTime.Now
        );
        employees.Rows.Add(
            null,
            "Mustafa",
            "Iraq",
            4950,
            DateTime.Now
        );

        DataColumn[] primaryKeyColumns = new DataColumn[1];
        primaryKeyColumns[0] = employees.Columns["ID"]!;
        employees.PrimaryKey = primaryKeyColumns;

        printEmployees(
            "Employee List",
            ref employees
        );
    }

    private static DataColumn defineColumn(
        string name,
        Type   type,
        bool   isAutoIncrement   = false,
        int    autoIncrementSeed = 1,
        int    autoIncrementStep = 1,
        string caption           = "",
        bool   isReadOnly        = false,
        bool   isUnique          = false
    ) {
        DataColumn dataColumn = new DataColumn();
        dataColumn.ColumnName        = name;
        dataColumn.DataType          = type;
        dataColumn.AutoIncrement     = isAutoIncrement;
        dataColumn.AutoIncrementSeed = autoIncrementSeed;
        dataColumn.AutoIncrementStep = autoIncrementStep;
        dataColumn.Caption           = caption;
        dataColumn.ReadOnly          = isReadOnly;
        dataColumn.Unique            = isUnique;
        return dataColumn;
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