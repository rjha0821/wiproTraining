using System;

class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[5];
        int employeeCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Employee Management System");
            Console.WriteLine("1. Create Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Create Employee
                    if (employeeCount < employees.Length)
                    {
                        Employee newEmployee = CreateEmployee();
                        employees[employeeCount] = newEmployee;
                        employeeCount++;
                        Console.WriteLine("Employee Created Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Employee list is full!");
                    }
                    break;

                case "2":
                    // View Employees
                    ViewEmployees(employees, employeeCount);
                    break;

                case "3":
                    // Update Employee
                    UpdateEmployee(employees, employeeCount);
                    break;

                case "4":
                    // Delete Employee
                    DeleteEmployee(employees, ref employeeCount);
                    break;

                case "5":
                    // Exit
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    // Create Employee Method
    public static Employee CreateEmployee()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Employee Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Employee Department: ");
        string department = Console.ReadLine();
        return new Employee(name, age, department);
    }

    // View Employees Method
    public static void ViewEmployees(Employee[] employees, int employeeCount)
    {
        if (employeeCount == 0)
        {
            Console.WriteLine("No employees to display.");
        }
        else
        {
            Console.WriteLine("\nEmployee List:");
            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"ID: {i + 1}, Name: {employees[i].Name}, Age: {employees[i].Age}, Department: {employees[i].Department}");
            }
        }
    }

    // Update Employee Method
    public static void UpdateEmployee(Employee[] employees, int employeeCount)
    {
        Console.Write("Enter Employee ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine()) - 1;

        if (id >= 0 && id < employeeCount)
        {
            Console.WriteLine($"Updating Employee {id + 1}");
            Console.Write("Enter new Name: ");
            employees[id].Name = Console.ReadLine();
            Console.Write("Enter new Age: ");
            employees[id].Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new Department: ");
            employees[id].Department = Console.ReadLine();
            Console.WriteLine("Employee updated successfully!");
        }
        else
        {
            Console.WriteLine("Invalid Employee ID!");
        }
    }

    // Delete Employee Method
    public static void DeleteEmployee(Employee[] employees, ref int employeeCount)
    {
        Console.Write("Enter Employee ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine()) - 1;

        if (id >= 0 && id < employeeCount)
        {
            for (int i = id; i < employeeCount - 1; i++)
            {
                employees[i] = employees[i + 1];
            }
            employees[employeeCount - 1] = null; // Remove the last reference
            employeeCount--;
            Console.WriteLine("Employee deleted successfully!");
        }
        else
        {
            Console.WriteLine("Invalid Employee ID!");
        }
    }
}

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public Employee(string name, int age, string department)
    {
        Name = name;
        Age = age;
        Department = department;
    }
}


Program.Main();