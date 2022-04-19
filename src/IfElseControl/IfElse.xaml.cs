using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace IfElseControl
{
    [ContentProperty(nameof(Content))]
    public partial class IfElse : ContentControl
    {
        public IfElse()
        {
            InitializeComponent();
        }

        // dependency prop object Condition..
        public bool Condition
        {
            get => (bool)GetValue(ConditionProperty);
            set => SetValue(ConditionProperty, value);
        }
        public static readonly DependencyProperty ConditionProperty = 
            DependencyProperty.Register(nameof(Condition), typeof(bool), typeof(IfElse),
                new PropertyMetadata(false, new PropertyChangedCallback(conditionChanged))
            )
        static void conditionChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var cond = (bool)args.NewValue;

            var newContent = (condition)
                ? o.GetValue(IfProperty)
                : o.GetValue(ElseProperty);

            o.SetValue(ContentProperty, newContent);
        }

        // dependency prop object If..
        public object If
        {
            get => GetValue(IfProperty);
            set => SetValue(IfProperty, value);
        }
        public static readonly DependencyProperty IfProperty = 
            DependencyProperty.Register(nameof(If), typeof(object), typeof(IfElse),
                new PropertyMetadata(new PropertyChangedCallback(ifChanged))
            )
        static void ifChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var cond = (bool)o.GetValue(ConditionProperty);

            if(cond)
                o.SetValue(ContentProperty, args.NewValue);
        }

        // dependency prop object Else..
        public object Else
        {
            get => GetValue(ElseProperty);
            set => SetValue(ElseProperty, value);
        }
        public static readonly DependencyProperty ElseProperty = 
            DependencyProperty.Register(nameof(Else), typeof(object), typeof(IfElse),
                new PropertyMetadata(new PropertyChangedCallback(elseChanged))
            )
        static void elseChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var cond = (bool)o.GetValue(ConditionProperty);

            if(!cond)
                o.SetValue(ContentProperty, args.NewValue);
        }
    }
}
