using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using TestingXamarin;
using Xamarin.Forms;



namespace TestingXamarin
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new ListDemo();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
			AppCenter.Start("ios=5aa23916-6c52-4fc4-af57-74400869b058;" +
							"uwp={Your UWP App secret here};" +
							"android={Your Android App secret here}",
				typeof(Analytics), typeof(Crashes));

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
