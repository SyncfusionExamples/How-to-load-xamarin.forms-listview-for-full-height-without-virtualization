using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfListViewSample
{
	  public partial class MainPage : ContentPage
    {

        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            listView1.Loaded += ListView1_Loaded;
            listView2.Loaded += ListView2_Loaded;
        }

        private void ListView1_Loaded(object sender, ListViewLoadedEventArgs e)
        {
            var container = listView1.GetVisualContainer();
            var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(container);
            listView1.HeightRequest = extent;
        }

        private void ListView2_Loaded(object sender, ListViewLoadedEventArgs e)
        {
            var container = listView2.GetVisualContainer();
            var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(container);
            listView2.HeightRequest = extent;
        }
        #endregion
    }
    
}
