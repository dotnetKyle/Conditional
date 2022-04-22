using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Conditional;

/// <summary>
/// Interaction logic for If.xaml
/// </summary>
[ContentProperty(nameof(Content))]
public partial class If : ContentControl
{
    public If()
    {
        InitializeComponent();

        var condition = (bool)GetValue(ConditionProperty);
        SetValue(VisibilityProperty, condition ? Visibility.Visible : Visibility.Collapsed);
    }


    // dependency prop object Condition..
    public bool Condition
    {
        get => (bool)GetValue(ConditionProperty);
        set => SetValue(ConditionProperty, value);
    }
    public static readonly DependencyProperty ConditionProperty =
        DependencyProperty.Register(nameof(Condition), typeof(bool), typeof(If),
            new PropertyMetadata(false, new PropertyChangedCallback(conditionChanged))
        );
    static void conditionChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
    {
        var condition = (bool)args.NewValue;

        var visibility = (condition)
            ? Visibility.Visible
            : Visibility.Collapsed;

        o.SetValue(VisibilityProperty, visibility);
    }
}
