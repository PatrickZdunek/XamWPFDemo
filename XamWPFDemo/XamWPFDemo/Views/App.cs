using System;
using Xamarin.Forms;
using XamWPFDemo.Views;

namespace XamWPFDemo
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new RootPage();
        }
    }
}
