using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Lukbuk
{
	public partial class LukbukImage : ContentView
	{
		Image myImage = null;
		Label description = null;
		Label title = null;

		public LukbukImage()
		{
		}

		public LukbukImage(string image, string brand, string imagedescription)
		{
			InitializeComponent();
			title = this.FindByName<Label>("Name");
			title.Text = brand;
			myImage = this.FindByName<Image>("actualImage");
			myImage.Source = ImageSource.FromUri(new Uri(image));
			description = this.FindByName<Label>("myDescription");
			description.Text = imagedescription;

		}

		void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
		{
		}


		void OnTapGestureRecognizerTapped(object sender, EventArgs args) {
			if (description.IsVisible)
			{
				description.IsVisible = false;
			}
			else
			{
				description.IsVisible = true;
			}
		}
	}
}
