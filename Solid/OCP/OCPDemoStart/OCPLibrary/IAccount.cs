using OCPLibrary;
using oopWithCsharp.Solid.OCP.OCPDemoStart.OCPLibrary;

public interface IAccounts
{
    EmployeeModel Create(IPersonModel person);
}