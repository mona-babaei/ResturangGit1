namespace ResturangGit;

using System;
using System.Collections.Generic;

public class Employee
{
    public string? Name { get; set; }
    public decimal Salary { get; set; }
}

 class Program
{
    static List<Employee> employees = new();
    private static object employee;

    public static List<Employee> Employees { get => employees; set => employees = value; }

    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add Employees");
            Console.WriteLine("2. Show Employees");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    ShowEmployees();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select again.");
                    break;
            }
        }
    }

    static void AddEmployee()
    {
        Console.Write("Employee Name: ");
        var name = Console.ReadLine();

        Console.Write("Salary: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal salary))
        {
            employees.Add(new Employee { Name = name, Salary = salary });
            Console.WriteLine("Employees added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid salary value.");
        }
    }

    private static void ShowEmployees()
    {
        Console.WriteLine("Employee List:");
        foreach ( var employee in employees)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary:C}");

        }
    }
}