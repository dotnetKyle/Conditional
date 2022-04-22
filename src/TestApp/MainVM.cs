using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestApp;
public class MainVM : INotifyPropertyChanged, IMainVM
{
    bool isEditMode;
    public bool IsEditMode
    {
        get => isEditMode;
        set { isEditMode = value; propChanged(); }
    }

    string firstName = "";
    public string FirstName
    {
        get => firstName;
        set { firstName = value; propChanged(); }
    }

    string middleName = "";
    public string MiddleName
    {
        get => middleName;
        set { middleName = value; propChanged(); }
    }

    string lastName = "";
    public string LastName
    {
        get => lastName;
        set { lastName = value; propChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    void propChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}