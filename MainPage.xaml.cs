using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.dataGrid.Loaded += OnDataGrid_Loaded;
        }

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
    }
}
