using System;

using Xamarin.Forms;

namespace VideoplayerTest
{
	public class VideoPlayerApp : Application
	{
		public VideoPlayerApp()
		{
			NavigationPage navPage = new NavigationPage(new VideoPlayerPage());

			MainPage = navPage;
		}

		protected override void OnStart()
		{
			base.OnStart();
		}

		protected override void OnSleep()
		{
			base.OnSleep();
		}

		protected override void OnResume()
		{
			base.OnResume();
		}
	}
}

