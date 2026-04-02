# How-to-load-xamarin.forms-listview-for-full-height-without-virtualization ?
This example demonstrates how to load xamarin.forms listview for full height without virtualization.

## Sample

```xaml
<ScrollView>
        <syncfusion:SfListView  x:Name="listView"
                        ItemsSource="{Binding Contactsinfo}">
            <syncfusion:SfListView.Behaviors>
                <local:ListViewBehavior/>
            </syncfusion:SfListView.Behaviors>
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <ViewCell.View>
                            <Grid x:Name="grid" RowSpacing="1">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="*" />
                                    <RowDefinition Height="1" />
                                </Grid.RowDefinitions>
                                . . .
                                . . .
                                </Grid>
                                <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                            </Grid>
                        </ViewCell.View>
                    </ViewCell>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
</ScrollView>

listView.Loaded += OnListViewLoaded;

private void OnListViewLoaded(object sender, ListViewLoadedEventArgs e)
{
   var container = listView.GetVisualContainer();
   var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(container);
   listView.HeightRequest = extent;
}
```

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
