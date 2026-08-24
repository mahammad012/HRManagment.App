namespace HRManagment.App;

class Program
{
    static void Main(string[] args)
    {
        HumanResourceManager manager = new HumanResourceManager();

        manager.AddDepartment("Maliyye", 5, 5000);
        manager.AddDepartment("IT", 3, 3000);

        manager.AddEmployee("Mahammad Valiyev", "Developer", 1000, "IT");

        manager.AddEmployee("Ali Aliyev", "Manager", 1500, "Maliyye");

        foreach (Department department in manager.GetDepartments())
        {
            Console.WriteLine(department.Name);

            foreach (Employee employee in department.Employees)
            {
                Console.WriteLine($"{employee.No} - {employee.FullName} - {employee.Position} - {employee.Salary}");
            }

            Console.WriteLine($"Average: {department.CalcSalaryAverage()}");
        }
    }
}