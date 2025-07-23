using System;
using System.Data;
using System.Data.SqlClient;
using ConsoleApplications.Utilities;

namespace ConsoleApplications._7_data_adapter;

public class DataAdapter {
    public static void Main() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_ALL_EMPLOYEES = """
                                            USE HR_Database
                                            SELECT * FROM Employees
                                            """;
        const string QUERY   = SELECT_ALL_EMPLOYEES;
        DataSet      dataSet = new DataSet();
        sqlConnection.Open();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
            QUERY,
            Constants.DATABASE_CONNECTIVITY
        );
        sqlDataAdapter.SelectCommand.Connection = sqlConnection;
        sqlDataAdapter.Fill(
            dataSet,
            "Employees"
        );
        sqlConnection.Close();
        DataTable employees = dataSet.Tables["Employees"]!;
        foreach (DataRow employee in employees.Rows)
            Console.WriteLine(
                "ID : {0,-4}, FirstName : {1,-14}, LastName : {2,-14}, Gender : {3,-1}, DateOfBirth : {4,-12}, CountryID : {5,-2}, DepartmentID : {6,-2}, HireDate : {7,-22}, ExitDate : {8,-22}, MonthlySalary : {9,-12}, BonusPerc : {10}",
                employee["ID"],
                employee["FirstName"],
                employee["LastName"],
                employee["Gender"],
                employee["DateOfBirth"],
                employee["CountryID"],
                employee["DepartmentID"],
                employee["HireDate"],
                employee["ExitDate"],
                employee["MonthlySalary"],
                employee["BonusPerc"]
            );
    }
}