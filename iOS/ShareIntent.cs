using System;
using UIKit;
using Foundation;
using Lukbuk.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (ShareIntent))]
namespace Lukbuk.iOS
{
	public class ShareIntent : IShareable
	{
		public void OpenShareIntent(string textToShare)
		{
			var activityController = new UIActivityViewController(new NSObject[] { UIActivity.FromObject(textToShare) }, null);
			UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(activityController, true, null);
		}
	}
}