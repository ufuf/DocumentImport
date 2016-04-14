using System;

using Xamarin.Forms;

namespace FileShareTest
{
	public class App : Application
	{
		//static variable to be able to access from native project
		public static MyPage page;

		public App ()
		{
			// The root page of your application
			page = new MyPage ();
			MainPage = page;
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

