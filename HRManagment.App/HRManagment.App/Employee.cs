namespace HRManagment.App;

public class Employee
{
    private static int _employeeCount = 1000;
    public string No { get; }
    public string FullName { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public string DepartmentName { get; set; }

    public Employee(string fullname, string position, decimal salary, string departmentName)
    {
        if(string.IsNullOrWhiteSpace(fullname))
            throw new ArgumentException("Fullname cannot be null or empty");
        if(position.Length < 2)
            throw new ArgumentException("Position cannot be less than 2");
        if (salary < 250)
            throw new ArgumentException("Salary cannot be less than 250");
        FullName = fullname;
        Position = position;
        Salary = salary;
        DepartmentName = departmentName;
        No = departmentName.Substring(0, 2).ToUpper() + _employeeCount;
        _employeeCount++;
    }
}