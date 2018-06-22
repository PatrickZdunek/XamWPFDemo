using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamWPFDemo.Views;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamWPFDemo
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();

            var np = new NavigationPage(new MenuView());
			MainPage = np;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
