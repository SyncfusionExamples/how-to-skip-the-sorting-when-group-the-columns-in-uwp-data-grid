# How to skip the sorting when group the columns in UWP DataGrid (SfDataGrid) ?

## About the sample

This sample illustrates how to skip the sorting when group the columns in UWP DataGrid.

By default, SfDataGrid groups a column in the sorted order. However, you can group a specific column in the actual order without sorting the groups in SfDataGrid by removing the grouped column from the SfDataGrid.View.SortDescriptions.

```c#

this.dataGrid.Loaded += OnDataGrid_Loaded;

private void OnDataGrid_Loaded(object sender, RoutedEventArgs e)
{
    this.dataGrid.View.CurrentChanged += OnView_CurrentChanged;
}

private void OnView_CurrentChanged(object sender, object e)
{
    var groupColumn = dataGrid.View.SortDescriptions.FirstOrDefault(x => x.PropertyName == "ProductName");

    if (dataGrid.SortColumnDescriptions.FirstOrDefault(x => x.ColumnName == "ProductName") != null)
        dataGrid.View.SortDescriptions.Remove(groupColumn);
}

```

![Grouing without sorting in SfDataGrid](image.png)

## Requirements to run the demo
Visual Studio 2015 and above versions

