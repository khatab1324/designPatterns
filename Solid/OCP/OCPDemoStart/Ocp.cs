using OCPLibrary;
using oopWithCsharp.Solid.OCP.OCPDemoStart.OCPLibrary;

namespace oopWithCsharp.Solid;

public class CreateEmploy
{
    static CreateEmploy()
    {
        List<IPersonModel> people = new List<IPersonModel>{
        new PersonModel{FirstName="khattab",LastName="fayyad"},
        new MangaerModel{FirstName="sami",LastName="fayyad"},
        new PersonModel{FirstName="khalid",LastName="fayyad"}
    };
        List<EmployeeModel> employees = new List<EmployeeModel>();

        foreach (var person in people)
        {
            employees.Add(person.accounts.Create(person));
        }
        foreach (var emp in employees)
        {
            System.Console.WriteLine($"{emp.FirstName} {emp.LastName} : {emp.EmailAddress} | is manager :{emp.IsManager}");
        }
    }

}