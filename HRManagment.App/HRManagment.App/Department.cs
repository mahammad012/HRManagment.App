namespace HRManagment.App;

public class Department
{
    public string Name { get; set; }
    public int WorkerLimit { get; set; }
    public decimal SalaryLimit { get; set; }
    public Employee[] Employees { get; set; }

    public Department(string name, int workerLimit, decimal salaryLimit)
    {
        if (name.Length < 2)
            throw new ArgumentException("Department name must be at least 2 characters long");

        if (workerLimit < 1)
            throw new ArgumentException("Worker limit must be at least 1");

        if (salaryLimit < 250)
            throw new ArgumentException("Salary limit must be at least 250");

        Name = name;
        WorkerLimit = workerLimit;
        SalaryLimit = salaryLimit;
        Employees = new Employee[0];
    }

    public decimal CalcSalaryAverage()
    {
        if (Employees.Length == 0)
            return 0;

        decimal total = 0;

        foreach (Employee employee in Employees)
        {
            total += employee.Salary;
        }

        return total / Employees.Length;
    }
}
