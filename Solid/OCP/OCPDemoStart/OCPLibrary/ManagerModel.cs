using oopWithCsharp.Solid.OCP.OCPDemoStart.OCPLibrary;

namespace OCPLibrary
{


    public class MangaerModel : IPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts accounts { get; set; } = new MangagerAccount();
    }
}