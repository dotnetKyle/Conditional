# Conditional if-else control
An If Else control for WPF

## If Example

```xml
<Window ...
        xmlns:conditional="clr-namespace:Conditional;assembly=Conditional"
        ...

        <conditional:If Condition="{Binding IsValidated}">
            <Button Click="Save_Click">Save</Button>
        </conditional:If>
```

## If-Else Example

```xml
<Window ...
        xmlns:conditional="clr-namespace:Conditional;assembly=Conditional"
        ...

        <conditional:IfElse Condition="{Binding IsInEditMode}">
            
            <conditional:IfElse.If>
                <TextBox Text="{Binding MyText}" />
                <Button Click="Save_Click">Save</Button>
            </conditional:IfElse.If>

            <conditional:IfElse.Else>
                <Label Content="{Binding MyText}" />
                <Button Click="Start_Edit_Mode">Edit</Button>
            </conditional:IfElse.Else>

        </conditional:IfElse>

```
