using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamWPFDemo.Views;

namespace XamWPFDemo.Models
{
    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;
            SeparatorVisibility = SeparatorVisibility.None;

            var cell = new DataTemplate(typeof(MenuCell));
            cell.SetBinding(MenuCell.TextProperty, "Title");
            cell.SetBinding(MenuCell.ImageSourceProperty, "IconSource");

            ItemTemplate = cell;
        }
    }
}
