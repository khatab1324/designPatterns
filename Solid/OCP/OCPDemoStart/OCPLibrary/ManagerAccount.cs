using oopWithCsharp.Solid.OCP.OCPDemoStart.OCPLibrary;

namespace OCPLibrary;
public class MangagerAccount : IAccounts
{
    public EmployeeModel Create(IPersonModel person)
    {
        EmployeeModel employee = new EmployeeModel();

        employee.FirstName = person.FirstName;
        employee.LastName = person.LastName;
        employee.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecrop.com";
        employee.IsManager = true;

        return employee;
    }
}