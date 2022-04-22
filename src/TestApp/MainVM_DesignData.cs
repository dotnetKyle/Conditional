using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestApp;

public class MainVM_DesignData : INotifyPropertyChanged, IMainVM
{
    public bool IsEditMode { get; set; } = true;
    public string FirstName { get; set; } = "John";
    public string MiddleName { get; set; } = "H";
    public string LastName { get; set; } = "Smith";

#pragma warning disable CS0067 // #warning directive
    public event PropertyChangedEventHandler? PropertyChanged;
#pragma warning restore CS0067 // #warning directive
}
