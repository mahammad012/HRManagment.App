# HR Management App

A simple Human Resources Management application developed in C#.

## Features

- Create and manage departments
- Add employees to departments
- Remove employees from departments
- Edit department names
- Edit employee salary and position
- Search employees
- Calculate the average salary of a department
- Generate unique employee numbers based on department name and employee creation order

## Project Structure

- `Employee.cs` — Represents an employee
- `Department.cs` — Represents a department
- `IHumanResourceManager.cs` — Defines HR management operations
- `HumanResourceManager.cs` — Implements the HR management operations
- `Program.cs` — Used to run and test the application

## Employee

The `Employee` class contains:

- `No` — Employee number
- `FullName` — Employee's full name
- `Position` — Employee's position
- `Salary` — Employee's salary
- `DepartmentName` — Employee's department

Employee numbers start from `1000` and contain the first two letters of the department name.

Example:

`IT1000`

`MA1001`

`HR1002`

## Department

The `Department` class contains:

- `Name` — Department name
- `WorkerLimit` — Maximum number of employees
- `SalaryLimit` — Maximum total monthly salary
- `Employees` — Employees working in the department

### Method

`CalcSalaryAverage()` returns the average salary of employees in the department.

## IHumanResourceManager

The `IHumanResourceManager` interface defines the main HR management operations:

- `AddDepartment()`
- `GetDepartments()`
- `EditDepartments()`
- `AddEmployee()`
- `RemoveEmployee()`
- `EditEmployee()`
- `Search()`

## HumanResourceManager

The `HumanResourceManager` class implements `IHumanResourceManager`.

It manages departments and employees using arrays.

## Technologies

- C#
- .NET

## Concepts Practiced

This project was created to practice:

- Classes and Objects
- Constructors
- Properties
- Interfaces
- Arrays
- Methods
- `foreach` loops
- `for` loops
- `Array.Resize()`
- Object-Oriented Programming

## How to Run

Open the project in Rider or Visual Studio and run the application.

Or use:

```bash
dotnet run