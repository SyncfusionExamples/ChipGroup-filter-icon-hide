# How-do-I-remove-the-indicator-icon-from-the-Xamarin.Forms-Chip

This example demonstrates how to hide the check icon while selecting the chip in Filter ChipGroup

[How to remove the indicator icon from Xamarin.Forms (SfChipGroup)](https://www.syncfusion.com/kb/11270/?utm_medium=listing&utm_source=github-examples)

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

See Also:

[What are the types available in ChipGroup?](https://help.syncfusion.com/xamarin/chips/types)

[What are the customizations available in ChipGroup?](https://help.syncfusion.com/xamarin/chips/customization)

[How to notify selection changes in ChipGroup?](https://help.syncfusion.com/xamarin/chips/events#selectionchanged-event)

Also refer our [feature tour](https://www.syncfusion.com/xamarin-ui-controls/xamarin-chips) page to know more features available in our chips.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
