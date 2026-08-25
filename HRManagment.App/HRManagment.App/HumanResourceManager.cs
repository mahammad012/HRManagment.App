namespace HRManagment.App;

public class HumanResourceManager : IHumanResourceManager
{
    private Department[] _departments = new Department[0];

    public Department[] Departments => _departments;

    public void AddDepartment(string name, int workerLimit, decimal salaryLimit)
    {
        Department department = new Department(
            name,
            workerLimit,
            salaryLimit);

        Array.Resize(ref _departments, _departments.Length + 1);

        _departments[^1] = department;
    }

    public Department[] GetDepartments()
    {
        return _departments;
    }

    public void EditDepartments(
        string oldName,
        string newName)
    {
        foreach (Department department in _departments)
        {
            if (department.Name == oldName)
            {
                department.Name = newName;
                return;
            }
        }
    }

    public void AddEmployee(string fullname, string position, decimal salary, string departmentName)
    {
        foreach (Department department in _departments)
        {
            if (department.Name == departmentName)
            {
                Employee employee = new Employee(fullname, position, salary, departmentName);

                Employee[] employees = department.Employees;

                Array.Resize(ref employees, employees.Length + 1);

                employees[^1] = employee;

                department.Employees = employees;

                return;
            }
        }
    }

    public void RemoveEmployee(string employeeNo, string departmentName)
    {
        foreach (Department department in _departments)
        {
            if (department.Name == departmentName)
            {
                for (int i = 0; i < department.Employees.Length; i++)
                {
                    if (department.Employees[i].No == employeeNo)
                    {
                        for (int j = i; j < department.Employees.Length - 1; j++)
                        {
                            department.Employees[j] =
                                department.Employees[j + 1];
                        }

                        Employee[] employees = department.Employees;

                        Array.Resize(ref employees, employees.Length - 1);

                        department.Employees = employees;

                        return;
                    }
                }
            }
        }
    }

    public void EditEmployee(
        string employeeNo,
        decimal salary,
        string position)
    {
        foreach (Department department in _departments)
        {
            foreach (Employee employee in department.Employees)
            {
                if (employee.No == employeeNo)
                {
                    employee.Salary = salary;
                    employee.Position = position;

                    return;
                }
            }
        }
    }

    public Employee[] Search(string value)
    {
        Employee[] result = new Employee[0];

        foreach (Department department in _departments)
        {
            foreach (Employee employee in department.Employees)
            {
                if (employee.FullName.Contains(value))
                {
                    Array.Resize(
                        ref result,
                        result.Length + 1);

                    result[^1] = employee;
                }
            }
        }

        return result;
    }
}