using System.Windows;

namespace TestApp;

public partial class MainWindow : Window
{
    MainVM vm;
    public MainWindow()
    {
        InitializeComponent();

        vm = new MainVM();
        DataContext = vm;
    }

    void Cancel_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    void ViewMode_Click(object sender, RoutedEventArgs e)
    {
        vm.IsEditMode = false;
    }

    void EditMode_Click(object sender, RoutedEventArgs e)
    {
        vm.IsEditMode = true;
    }
}