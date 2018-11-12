using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace SfListViewSample
{
    public class ListViewBehavior : Behavior<SfListView>
    {
        private SfListView listView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            listView = bindable;
            listView.Loaded += OnListViewLoaded;
            base.OnAttachedTo(bindable);
        }

        private void OnListViewLoaded(object sender, ListViewLoadedEventArgs e)
        {
            var container = listView.GetVisualContainer();
            var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(container);
            listView.HeightRequest = extent;
        }

        protected override void OnDetachingFrom(SfListView bindable)
        {
            listView.Loaded -= OnListViewLoaded;
            base.OnDetachingFrom(bindable);
        }
    }
}
