using System;
using TaskPlanApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TaskPlanApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            var main = new NavigationPage();
            main.BarBackgroundColor = Color.LightBlue;
            var simpleTaskPage = new TaskPage();
            main.PushAsync(simpleTaskPage);
			MainPage = main;
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
