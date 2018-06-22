using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamWPFDemo.Models;
using Xamarin.Forms;

namespace XamWPFDemo.Views
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;

        public RootPage()
        {
            menuPage = new MenuPage();

            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as Models.MenuItem);

            Master = menuPage;
            Detail = new NavigationPage(new ContractsPage());
        }

        void NavigateTo (Models.MenuItem menu)
        {
            if (menu == null)
                return;

            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}