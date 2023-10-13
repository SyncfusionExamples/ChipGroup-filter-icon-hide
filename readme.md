
# Getting Started with Chip sample
Step 1: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**

```
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
**[C#]**

```
using Syncfusion.XForms.Buttons;
```
Step 2: Then initialize an empty SfChipGroup as shown in the following code:

**[XAML]**

```
<ContentPage.Content>
  <Grid>
     <buttons:SfChipGroup/>
  </Grid>
</ContentPage.Content>
```
**[C#]**
```
public GettingStarted()
{
  InitializeComponent();
  Grid grid = new Grid();
  grid.Children.Add(new SfChipGroup());
  this.Content = grid;
}
```

# How do I remove the indicator icon from the Xamarin.Forms-Chip

To hide the selected chip selection indicator icon was achieved by adding the SfChip as the [ItemTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.Buttons.XForms~Syncfusion.XForms.Buttons.SfChipGroup~ItemTemplate.html) of a ChipGroup. The default value of the SfChip&#39;s [ShowSelectionIndicator](https://help.syncfusion.com/xamarin/chips/customization#showselectionindicator) property is false. Since, the selection indicator icon will be hidden by default while using the SfChip as an ItemTemplate.

In addition, we have to set the Transparent color to the BackgroundColor and BorderColor of the Chip in the ItemTemplate. It will take the BackgroundColor from the [SelectedChipBackgroundColor](https://help.syncfusion.com/xamarin/chips/customization#selectedchipbackgroundcolor) and [ChipBackgroundColor](https://help.syncfusion.com/xamarin/chips/customization#chipbackgroundcolor) properties of ChipGroup. TextColor of the chips has been updated based on the [IsChecked](https://help.syncfusion.com/cr/xamarin/Syncfusion.Buttons.XForms~Syncfusion.XForms.Buttons.SfButton~IsChecked.html) value with [ChipTextColor](https://help.syncfusion.com/xamarin/chips/customization#chiptextcolor) and [SelectedChipTextColor](https://help.syncfusion.com/xamarin/chips/customization#selectedchiptextcolor) properties as per the following code example.

**XAML:**

```
…
<buttons:SfChipGroup 
                Type="Filter" 
                x:Name="chipGroup"
                SelectedChipBackgroundColor="DarkGray"
                ChipBackgroundColor="LightGray"
                ChipTextColor="Black"
                SelectedChipTextColor="White"
                SelectionChanged="SessionListFilterOptions_SelectionChanged"
				ItemsSource="{Binding Languages}"
				ChipPadding="8,8,0,0"
                SelectionIndicatorColor="White"
				>
                <buttons:SfChipGroup.ItemTemplate>
                    <DataTemplate>
                        <buttons:SfChip  Text="{Binding Name}" InputTransparent="True"
                                         BorderColor="Transparent" 
                                         BorderWidth="0"
                                         TextColor="{Binding Source={x:Reference chipGroup},Path=ChipTextColor}"
                                         BackgroundColor="Transparent">
                            <buttons:SfChip.Triggers>
                                <DataTrigger TargetType="buttons:SfChip" Binding="{Binding IsChecked}"  Value="True" >
                                    <Setter Property="TextColor" Value="{Binding Source= {x:Reference chipGroup}, Path=SelectedChipTextColor}"/>
                                </DataTrigger>
                            </buttons:SfChip.Triggers>
                        </buttons:SfChip>
                    </DataTemplate>
                </buttons:SfChipGroup.ItemTemplate>
            </buttons:SfChipGroup>
…

```

**C#:**

```

private void SessionListFilterOptions_SelectionChanged(object sender, Syncfusion.Buttons.XForms.SfChip.SelectionChangedEventArgs e)
    {
        if (e.AddedItem != null)
        {
            (e.AddedItem as Language).IsChecked = true;
        }

        if (e.RemovedItem != null)
        {
            (e.RemovedItem as Language).IsChecked = false;
        }
    }


```

## How to run this application?

To run this application, you need to first clone the How-to-remove-the-indicator-icon-from-Xamarin.Forms-SfChipGroup repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.