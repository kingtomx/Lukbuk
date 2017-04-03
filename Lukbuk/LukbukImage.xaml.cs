using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Lukbuk
{
	public partial class LukbukImage : ContentView
	{
		public LukbukImage()
		{
		}

		public LukbukImage(String image)
		{
			InitializeComponent();
			Image myImage = this.FindByName<Image>("actualImage");
			myImage.Source = ImageSource.FromFile(image);

		}

		void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
		{
		}
	}
}
