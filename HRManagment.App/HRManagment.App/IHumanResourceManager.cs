namespace HRManagment.App;

public interface IHumanResourceManager
{
    Department[] Departments { get;}
    void AddDepartment(string name, int workerLimit,decimal salaryLimit);
    Department[] GetDepartments();
    void EditDepartments(string oldName, string newName);
    void AddEmployee(string fullName,string position,decimal salary,string departmentName);
    void RemoveEmployee(string employeeNo ,string departmentName);
    void EditEmployee( string employeeNo, decimal salary, string position);
    Employee[] Search(string value);
}