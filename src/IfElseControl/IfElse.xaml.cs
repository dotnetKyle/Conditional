<ContentControl x:Class="IfElseControl.If"
                xmlns="http://schemas.micrsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.micrsoft.com/winfx/2006/xaml">
  <ContentControl.Template>
    <ControlTemplate TargetType="ContentControl">
      <Grid>
        <ContentControl Content="{TemplateBinding Content}"/>
      </Grid>
    </ControlTemplate>
  </ContentControl.Template>
  
  <ContentPresenter />
</ContentControl>
