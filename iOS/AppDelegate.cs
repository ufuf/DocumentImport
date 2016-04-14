using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace FileShareTest.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}

		//Function to handle passed files...
		public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			Console.WriteLine ("Invoked with OpenUrl: {0}", url.AbsoluteString);

			//TODO: Insert app logic here...
			App.page.lbl.Text = url.AbsoluteString; //set label on screen
			App.page.uploadFile (System.Web.HttpUtility.UrlDecode(url.AbsoluteString)); //call upload function

			return true;
		}
	}
}

