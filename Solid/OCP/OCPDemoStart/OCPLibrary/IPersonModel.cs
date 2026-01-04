using System;

namespace oopWithCsharp.Solid.OCP.OCPDemoStart.OCPLibrary;

public interface IPersonModel
{
    string FirstName { get; set; }
    string LastName { get; set; }
    IAccounts accounts { get; set; }
}
