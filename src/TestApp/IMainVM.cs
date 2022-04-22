namespace TestApp
{
    public interface IMainVM
    {
        string FirstName { get; set; }
        bool IsEditMode { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
    }
}