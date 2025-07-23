using System;
using System.Data;

namespace ConsoleApplications._4_datatables._4_3_count_and_sum_and_avg_and_min_and_max;

public class CountAndSumAndAvgAndMinAndMax {
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

        Console.WriteLine(
            new string(
                '-',
                30
            )
        );

        int count = employees.Rows.Count;
        double totalSalaries = Convert.ToDouble(
            employees.Compute(
                "SUM(Salary)",
                string.Empty
            )
        );
        double averageSalaries = Convert.ToDouble(
            employees.Compute(
                "AVG(Salary)",
                string.Empty
            )
        );
        double minimumSalaries = Convert.ToDouble(
            employees.Compute(
                "MIN(Salary)",
                string.Empty
            )
        );
        double maximumSalaries = Convert.ToDouble(
            employees.Compute(
                "MAX(Salary)",
                string.Empty
            )
        );

        Console.Write(
            "Count: {0}"            + Environment.NewLine +
            "Total Salaries: {1}"   + Environment.NewLine +
            "Average Salaries: {2}" + Environment.NewLine +
            "Minimum Salaries: {3}" + Environment.NewLine +
            "Maximum Salaries: {4}" + Environment.NewLine,
            count,
            totalSalaries,
            averageSalaries,
            minimumSalaries,
            maximumSalaries
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